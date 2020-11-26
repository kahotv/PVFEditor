using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Utils
{
    public class EnumHelper
    {
        public class EnumInfo
        {
            public string Name;
            public int Value;
            public override string ToString()
            {
                return Name;
            }
        }

        public static EnumInfo[] GetEnumList(Type type)
        {
            FieldInfo[] fields = type.GetFields();

            return fields.Skip(1).Select(p => new EnumInfo 
            {
                Name = p.Name,
                Value = (int)p.GetValue(null)
            }).ToArray();

        }
        public static string GetEnumName(Type type,object value)
        {
            FieldInfo[] fields = type.GetFields();


            var find = fields.Skip(1).Where(p => p.Name == value.ToString()).FirstOrDefault();
            if(find != null)
            {
                return find.Name;
            }
            return "";
        }
    }
}
