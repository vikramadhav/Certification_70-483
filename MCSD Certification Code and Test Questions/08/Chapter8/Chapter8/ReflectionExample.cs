using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;

namespace Chapter8
{
    class ReflectionExample
    {
        private string _privateField = "Hello";
        public string _publicField = "Goodbye";
        internal string _internalfield = "Hola";
        protected string _protectedField = "Adios";
        static string _staticField = "Bonjour";

        public string PrivateField
        {
            get { return _privateField; }
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public static bool LoadClassFromSQLDataReader(object myClass, SqlDataReader dr)
        {
            if (dr.HasRows)
            {
                dr.Read();

                Type typeOfClass = myClass.GetType();

                object[] dataMappingAttributes = typeOfClass.GetCustomAttributes(typeof(DataMappingAttribute), false);

                for (int columnIndex = 0; columnIndex <= dr.FieldCount - 1; columnIndex++)
                {
                    //Get the name of the column.
                    string columnName = dr.GetName(columnIndex);

                    //Check if a property exists that matches that name.
                    PropertyInfo propertyInfo = null;

                    //Check if an attribute exists that maps this column to a property.
                    foreach (DataMappingAttribute dataMappingAttribute in dataMappingAttributes)
                    {
                        if (dataMappingAttribute.ColumnName == columnName)
                        {
                            propertyInfo = typeOfClass.GetProperty(dataMappingAttribute.PropertyName);
                            break;
                        }
                    }

                    //The the property was mapped explicitely then try to find a
                    //property with the same name as the column.
                    if (propertyInfo == null)
                    {
                        propertyInfo = typeOfClass.GetProperty(columnName);
                    }

                    //If you found a property then set its value.
                    if (propertyInfo != null)
                    {
                        //Set the value to the value in the SqlDataReader
                        propertyInfo.SetValue(myClass, dr.GetValue(columnIndex));
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
