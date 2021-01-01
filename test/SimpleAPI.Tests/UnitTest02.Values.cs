using System;
using Xunit;
using simpleAPI.Controllers;
using simpleAPI;

namespace SimpleAPI.TEST
{
    public class UnitTest02 {
        ValuesController test = new ValuesController();

        [Fact]
        public void TestGetOne() {
            Value returnValue = (Value) test.Get(2);
            Assert.Equal(2, returnValue.id);
        }

        [Fact]
        public void TestGetOneError() {
            String returnValue = (String) test.Get(-2);
            Assert.Equal("Item non trovato", returnValue);
        }

        [Fact]
        public void TestGetAll() {
            Value[] returnValue = test.Get();
            Assert.NotEmpty(returnValue);
        }    
    }
}
