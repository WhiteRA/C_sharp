using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


[AttributeUsage(AttributeTargets.Field)]
public class CustomNameAttribute : Attribute
{
    public string Name { get; }

    public CustomNameAttribute(string name)
    {
        Name = name;
    }
}

public class Serializer
{

    public static string ObjectToString(object obj)
    {
        Type type = obj.GetType();
        PropertyInfo[] properties = type.GetProperties();
        FieldInfo[] fields = type.GetFields();

        List<string> keyValuePairs = new List<string>();

        foreach (var property in properties)
        {
            keyValuePairs.Add($"{property.Name}:{property.GetValue(obj)}");
        }

        foreach (var field in fields)
        {
            string name = field.Name;
            CustomNameAttribute attribute = (CustomNameAttribute)Attribute.GetCustomAttribute(field, typeof(CustomNameAttribute));
            if (attribute != null)
            {
                name = attribute.Name;
            }
            keyValuePairs.Add($"{name}:{field.GetValue(obj)}");
        }

        return string.Join(", ", keyValuePairs);
    }


    public static T StringToObject<T>(string data) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();
        FieldInfo[] fields = type.GetFields();

        string[] pairs = data.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var pair in pairs)
        {
            string[] keyValue = pair.Split(':');
            string propertyName = keyValue[0].Trim();
            string propertyValue = keyValue[1].Trim();

            PropertyInfo property = properties.FirstOrDefault(p => p.Name == propertyName);
            if (property != null)
            {
                property.SetValue(obj, Convert.ChangeType(propertyValue, property.PropertyType));
            }
            else
            {
                FieldInfo field = fields.FirstOrDefault(f => f.Name == propertyName);
                if (field != null)
                {
                    field.SetValue(obj, Convert.ChangeType(propertyValue, field.FieldType));
                }
            }
        }

        return obj;
    }
}

public class MyClass
{
    [CustomName("CustomFieldName")]
    public int I = 0;

    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass { Name = "John", Age = 30, I = 42 };

        string serializedData = Serializer.ObjectToString(obj);
        Console.WriteLine("Serialized Data: " + serializedData);

        MyClass deserializedObj = Serializer.StringToObject<MyClass>(serializedData);
        Console.WriteLine($"Deserialized Object: Name={deserializedObj.Name}, Age={deserializedObj.Age}, I={deserializedObj.I}");
    }
}