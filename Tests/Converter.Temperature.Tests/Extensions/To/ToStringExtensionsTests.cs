﻿using System;
using System.Collections.Generic;
using System.Text;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To
{
    public class ToStringExtensionsTests
    {
        [Fact]
        public void Test_to_celsius_with_celsius_returns_same_value()
        {
            // Arrange.
            var input = new CelsiusString("42");

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_celsius_with_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const string expected = "10";
            var input = new FahrenheitString("50");

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_with_gas_returns_correct_value()
        {
            // Arrange.
            const string expected = "220";
            var input = new GasString("7");

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_with_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "1";
            var input = new KelvinString("274.15");

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_with_celsius_returns_same_value()
        {
            // Arrange.
            const string expected = "53.6";
            var input = new CelsiusString("12");

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_with_fahrenheit_returns_correct_value()
        {
            // Arrange.
            var input = new FahrenheitString("50");

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_fahrenheit_with_gas_returns_correct_value()
        {
            // Arrange.
            const string expected = "428";
            var input = new GasString("7");

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_with_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "33.8";
            var input = new KelvinString("274.15");

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_with_celsius_returns_correct_value()
        {
            // Arrange.
            const string expected = "6";
            var input = new CelsiusString("200");

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_with_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const string expected = "6";
            var input = new FahrenheitString("392");

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_with_gas_returns_same_value()
        {
            // Arrange.
            var input = new GasString("7");

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_gas_with_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "6";
            var input = new KelvinString("473.15");

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_with_celsius_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            var input = new CelsiusString("200");

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_with_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            var input = new FahrenheitString("392");

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_with_gas_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            var input = new GasString("6");

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_with_kelvin_returns_same_value()
        {
            // Arrange.
            var input = new KelvinString("473.15");

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(input.Temperature);
        }
    }
}