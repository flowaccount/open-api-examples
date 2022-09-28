/*
 * FlowAccount Open API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing EmployeeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EmployeeApiTests : IDisposable
    {
        private EmployeeApi instance;

        public EmployeeApiTests()
        {
            instance = new EmployeeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmployeeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EmployeeApi
            //Assert.IsType<EmployeeApi>(instance);
        }

        /// <summary>
        /// Test EmployeeAddEmployee
        /// </summary>
        [Fact]
        public void EmployeeAddEmployeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeModel employeeModel = null;
            //var response = instance.EmployeeAddEmployee(employeeModel);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test EmployeeGetById
        /// </summary>
        [Fact]
        public void EmployeeGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.EmployeeGetById(id);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test EmployeeGetCount
        /// </summary>
        [Fact]
        public void EmployeeGetCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.EmployeeGetCount();
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test EmployeeGetList
        /// </summary>
        [Fact]
        public void EmployeeGetListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PayrollQuery payrollQuery = null;
            //var response = instance.EmployeeGetList(payrollQuery);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test EmployeeNotExistList
        /// </summary>
        [Fact]
        public void EmployeeNotExistListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NotExistEmployee notExistEmployee = null;
            //var response = instance.EmployeeNotExistList(notExistEmployee);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test EmployeeRemove
        /// </summary>
        [Fact]
        public void EmployeeRemoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.EmployeeRemove(id);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test EmployeeUpdate
        /// </summary>
        [Fact]
        public void EmployeeUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeModel employeeModel = null;
            //var response = instance.EmployeeUpdate(employeeModel);
            //Assert.IsType<System.IO.Stream>(response);
        }
    }
}