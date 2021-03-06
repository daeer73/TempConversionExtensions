﻿using System;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests
{
    public class ToCelsiusIntTests
    {
        #region From Celsius

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(-345)]
        [InlineData(0)]
        [InlineData(7564)]
        [InlineData(int.MaxValue)]
        public void Test_int_extension_from_and_to_celsius_returns_correct_int_value(int value)
        {
            // Arrange.
            // Act.
            var result = value.FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Celsius

        #region From Fahrenheit
        
        [Theory]
        [InlineData(50, 10)]
        [InlineData(int.MinValue, -1193046489)]
        [InlineData(int.MaxValue, 1193046453)]
        public void Test_int_extensions_from_fahrenheit_to_celsius_returns_correct_int_value(int input, int expected)
        {
            // Arrange.
            // Act.
            var result = input.FromFahrenheit().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_int_extensions_from_kelvin_to_celsius_returns_correct_int_value()
        {
            // Arrange.
            const int expected = 1;
            const int input = 274;

            // Act.
            var result = input.FromKelvin().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_int_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_int_value()
        {
            // Arrange.
            const int input = int.MinValue;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin().ToCelsius());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData(1, 140)]
        [InlineData(2, 150)]
        [InlineData(3, 165)]
        [InlineData(4, 180)]
        [InlineData(5, 190)]
        [InlineData(6, 200)]
        [InlineData(7, 220)]
        [InlineData(8, 230)]
        [InlineData(9, 240)]
        [InlineData(10, 260)]
        public void Test_int_extensions_from_gas_to_celsius_returns_correct_int_value(int input, int expected)
        {
            // Arrange.
            // Act.
            var result = input.FromGas().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(11)]
        public void Test_int_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(int input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromGas().ToCelsius());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        #endregion From Gas
    }
}
