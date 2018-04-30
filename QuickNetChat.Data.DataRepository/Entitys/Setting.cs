using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace QuickNetChat.Data.DataRepository.Entitys
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [Table("Settings")]
    public class Setting : EntityBase
    {
        /// <summary>
        ///     Name of the Setting
        /// </summary>
        [Key]
        [Column("Key")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Key { get; set; }

        private int ValueInt { get; set; }

        private double ValueDouble { get; set; }

        private string ValueString { get; set; }

        private bool ValueBool { get; set; }

        public T GetValue<T>()
        {
            if (typeof(T) == typeof(int))
                return (T) Convert.ChangeType(ValueInt, typeof(T));
            if (typeof(T) == typeof(double))
                return (T) Convert.ChangeType(ValueDouble, typeof(T));
            if (typeof(T) == typeof(string))
                return (T) Convert.ChangeType(ValueString, typeof(T));
            if (typeof(T) == typeof(bool))
                return (T) Convert.ChangeType(ValueBool, typeof(T));

            throw new Exception(
                $"The type {typeof(T)} is not a valid setting type. Currently valid setting types are: \n" +
                GetType().GetProperties()
                    .Where(propertyInfo => propertyInfo.Name.StartsWith("Value")).Aggregate("",
                        (current, propertyInfo) => current + $"{propertyInfo.PropertyType}, ")
                    .TrimEnd(','));
        }

        public void SetValue<T>(T value)
        {
            if (typeof(T) == typeof(int))
                ValueInt = Convert.ToInt32(value);
            else if (typeof(T) == typeof(double))
                ValueDouble = Convert.ToDouble(value);
            else if (typeof(T) == typeof(string))
                ValueString = Convert.ToString(value);
            else if (typeof(T) == typeof(bool))
                ValueBool = Convert.ToBoolean(value);
            else
                throw new Exception(
                    $"The type {typeof(T)} is not a valid setting type. Currently valid setting types are: \n" +
                    GetType().GetProperties()
                        .Where(propertyInfo => propertyInfo.Name.StartsWith("Value")).Aggregate("",
                            (current, propertyInfo) => current + $"{propertyInfo.PropertyType}, ")
                        .TrimEnd(','));
        }
    }
}