﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Hosting;

namespace Site.Models {
    public partial class CommonHelper {
        /// <summary>
        /// Generate random digit code
        /// </summary>
        /// <param name="length">Length</param>
        /// <returns>Result string</returns>
        public static string GenerateRandomDigitCode(int length) {
            var random = new Random();
            string str = string.Empty;
            for(int i = 0; i < length; i++)
                str = String.Concat(str, random.Next(10).ToString());
            return str;
        }

        /// <summary>
        /// Returns an random interger number within a specified rage
        /// </summary>
        /// <param name="min">Minimum number</param>
        /// <param name="max">Maximum number</param>
        /// <returns>Result</returns>
        public static int GenerateRandomInteger(int min = 0, int max = int.MaxValue) {
            var randomNumberBuffer = new byte[10];
            new RNGCryptoServiceProvider().GetBytes(randomNumberBuffer);
            return new Random(BitConverter.ToInt32(randomNumberBuffer, 0)).Next(min, max);
        }

        /// <summary>
        /// Ensure that a string doesn't exceed maximum allowed length
        /// </summary>
        /// <param name="str">Input string</param>
        /// <param name="maxLength">Maximum length</param>
        /// <param name="postfix">A string to add to the end if the original string was shorten</param>
        /// <returns>Input string if its lengh is OK; otherwise, truncated input string</returns>
        public static string EnsureMaximumLength(string str, int maxLength, string postfix = null) {
            if(String.IsNullOrEmpty(str))
                return str;

            if(str.Length > maxLength) {
                var result = str.Substring(0, maxLength);
                if(!String.IsNullOrEmpty(postfix)) {
                    result += postfix;
                }
                return result;
            }

            return str;
        }

        /// <summary>
        /// Ensures that a string only contains numeric values
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>Input string with only numeric values, empty string if input is null/empty</returns>
        public static string EnsureNumericOnly(string str) {
            if(String.IsNullOrEmpty(str))
                return string.Empty;

            var result = new StringBuilder();
            foreach(char c in str) {
                if(Char.IsDigit(c))
                    result.Append(c);
            }
            return result.ToString();
        }

        /// <summary>
        /// Ensure that a string is not null
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>Result</returns>
        public static string EnsureNotNull(string str) {
            if(str == null)
                return string.Empty;

            return str;
        }

        /// <summary>
        /// Indicates whether the specified strings are null or empty strings
        /// </summary>
        /// <param name="stringsToValidate">Array of strings to validate</param>
        /// <returns>Boolean</returns>
        public static bool AreNullOrEmpty(params string[] stringsToValidate) {
            bool result = false;
            Array.ForEach(stringsToValidate, str => {
                if(string.IsNullOrEmpty(str)) result = true;
            });
            return result;
        }

        /// <summary>
        /// Compare two arrasy
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="a1">Array 1</param>
        /// <param name="a2">Array 2</param>
        /// <returns>Result</returns>
        public static bool ArraysEqual<T>(T[] a1, T[] a2) {
            //also see Enumerable.SequenceEqual(a1, a2);
            if(ReferenceEquals(a1, a2))
                return true;

            if(a1 == null || a2 == null)
                return false;

            if(a1.Length != a2.Length)
                return false;

            var comparer = EqualityComparer<T>.Default;
            for(int i = 0; i < a1.Length; i++) {
                if(!comparer.Equals(a1[i], a2[i])) return false;
            }
            return true;
        }

        /// <summary>
        /// Converts a value to a destination type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <typeparam name="T">The type to convert the value to.</typeparam>
        /// <returns>The converted value.</returns>
        public static T To<T>(object value) {
            return (T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Sets culture
        /// </summary>
        public static void SetCulture(CultureInfo culture = null) {
            if(culture == null)
                culture = new CultureInfo("en-US");

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        /// <summary>
        /// Maps a virtual path to a physical disk path.
        /// </summary>
        /// <param name="path">The path to map. E.g. "~/bin"</param>
        /// <returns>The physical path. E.g. "c:\inetpub\wwwroot\bin"</returns>
        public static string MapPath(string path) {
            if(HostingEnvironment.IsHosted) {
                return HostingEnvironment.MapPath(path);
            }

            //not hosted. For example, run in unit tests
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            path = path.Replace("~/", "").TrimStart('/').Replace('/', '\\');
            return Path.Combine(baseDirectory, path);
        }

        /// <summary>
        /// Month Converter
        /// </summary>
        /// <param name="val">val</param>
        public static string MonthConverter(DateTime val) {
            if(!IsValidDateTime(val))
                return string.Empty;

            return val.ToString("yyyy-MM");
        }

        /// <summary>
        /// Date Converter
        /// </summary>
        /// <param name="val">val</param>
        public static string DateConverter(DateTime val) {
            if(!IsValidDateTime(val))
                return string.Empty;

            return val.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Datetime Converter
        /// </summary>
        /// <param name="val">val</param>
        public static string DateTimeConverter(DateTime val) {
            if(!IsValidDateTime(val))
                return string.Empty;

            return val.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// Time Converter
        /// </summary>
        /// <param name="val">val</param>
        public static string TimeConverter(DateTime val) {
            if(!IsValidDateTime(val))
                return string.Empty;

            return val.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Time Converter
        /// </summary>
        /// <param name="val">val</param>
        public static string ShortTimeConverter(DateTime val) {
            if(!IsValidDateTime(val))
                return string.Empty;

            return val.ToString("mm′ss″");
        }

        /// <summary>
        /// Interval Converter
        /// </summary>
        /// <param name="val">val</param>
        public static string IntervalConverter(DateTime start, DateTime? end = null) {
            if(start == default(DateTime)) { return String.Empty; }
            if(!end.HasValue) { end = DateTime.Now; }
            var ts = end.Value.Subtract(start);
            return String.Format("{0:0000}.{1:00}:{2:00}:{3:00}", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
        }

        /// <summary>
        /// Interval Converter
        /// </summary>
        /// <param name="ts">TimeSpan</param>
        public static string IntervalConverter(TimeSpan ts) {
            return String.Format("{0:0000}.{1:00}:{2:00}:{3:00}", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
        }

        /// <summary>
        /// Create a string hash
        /// </summary>
        /// <param name="plainText">Text to encrypt</param>
        /// <param name="saltkey">Salk key</param>
        /// <param name="format">Encrypt format (hash algorithm)</param>
        /// <returns>text hash</returns>
        public static string CreateHash(string plainText, string saltkey = "", string format = "SHA1") {
            var text = String.Concat(plainText, saltkey);

            if(String.IsNullOrWhiteSpace(format))
                format = "SHA1";

            //return FormsAuthentication.HashPasswordForStoringInConfigFile(text, format);
            var algorithm = HashAlgorithm.Create(format);
            if(algorithm == null)
                throw new ArgumentException("Unrecognized hash name");

            var hashByteArray = algorithm.ComputeHash(Encoding.UTF8.GetBytes(text));
            return BitConverter.ToString(hashByteArray).Replace("-", "");
        }

        /// <summary>
        /// whether contain target in source.
        /// </summary>
        /// <param name="target">target</param>
        /// <param name="source">source</param>
        /// <returns>true/false</returns>
        public static bool ConditionContain(string target, string[] source) {
            if(target == null || source == null)
                return false;

            foreach(var src in source) {
                if(target.ToLowerInvariant().Contains(src.ToLowerInvariant()))
                    return true;
            }

            return false;
        }

        private static bool IsValidDateTime(DateTime val) {
            if(val == default(DateTime))
                return false;

            /*
             * 解决JsonSerializer.DeserializeFromString方法转换默认时间[default(DateTime)]会自动加上时区(+8H)
             * 在使用Redis缓存时，NServiceKit默认会使用JsonSerializer.SerializeToString方法对要缓存的数据进行Json序列化
             * 在获取缓存时，NServiceKit默认会使用JsonSerializer.DeserializeFromString方法对已缓存的数据进行Json反序列化
             * 它会将0001-01-01 00:00:00 反序列号为 0001-01-01 08:00:00
             */
            if(val == new DateTime(1, 1, 1, 8, 0, 0))
                return false;

            return true;
        }
    }
}