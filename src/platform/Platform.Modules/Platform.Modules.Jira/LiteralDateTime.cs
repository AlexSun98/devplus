﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Platform.Modules.Jira
{
    /// <summary>
    /// Force a DateTime field to use a string provided as the JQL query value.
    /// </summary>
    [SuppressMessage("N/A", "CS0660", Justification = "Operator overloads are used for LINQ to JQL provider.")]
    [SuppressMessage("N/A", "CS0661", Justification = "Operator overloads are used for LINQ to JQL provider.")]
    public class LiteralDateTime
    {
        private readonly string _dateTimeString;

        public LiteralDateTime(string dateTimeString)
        {
            _dateTimeString = dateTimeString;
        }

        public override string ToString()
        {
            return _dateTimeString;
        }

        public static bool operator ==(DateTime dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator !=(DateTime dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator >(DateTime dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator <(DateTime dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator >=(DateTime dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator <=(DateTime dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator ==(DateTime? dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator !=(DateTime? dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator >(DateTime? dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator <(DateTime? dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator >=(DateTime? dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }

        public static bool operator <=(DateTime? dateTime, LiteralDateTime literalDateTime)
        {
            return false;
        }
    }
}
