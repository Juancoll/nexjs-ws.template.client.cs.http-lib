/* 
 * tradin.api.server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using template.api.httpclient.Client;
using template.api.httpclient.Api;
using template.api.httpclient.Model;

namespace template.api.httpclient.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' DefaultApi
            //Assert.IsInstanceOf(typeof(DefaultApi), instance);
        }

        
        /// <summary>
        /// Test AppControllerGet
        /// </summary>
        [Test]
        public void AppControllerGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AppControllerGet();
            //Assert.IsInstanceOf(typeof(PackageJson), response, "response is PackageJson");
        }
        
        /// <summary>
        /// Test AppControllerGetVersion
        /// </summary>
        [Test]
        public void AppControllerGetVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AppControllerGetVersion();
            //Assert.IsInstanceOf(typeof(string), response, "response is string");
        }
        
    }

}
