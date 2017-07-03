﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Platform.Modules.Jira
{
    public class BaseIntegrationTest
    {
        public const string HOST = "http://localhost:2990/jira";

        protected readonly Jira _jira;
        protected readonly Random _random;

        public BaseIntegrationTest()
        {
            _jira = CreateJiraClient();
            _random = new Random();
        }

        public Jira CreateJiraClient()
        {
            return Jira.CreateRestClient(HOST, "admin", "admin");
        }
    }
}