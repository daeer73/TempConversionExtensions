﻿using System;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests
{
    public class ToKelvinDoubleTests
    {
        #region From Celsius

        [Fact]
        public void Test_double_extensions_from_celsius_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const double expected = 473.15d;
            var input = 200d;

            // Act.
            var result = input.FromCelsius().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_double_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToKelvin());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_double_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const double expected = 473.15d;
            var input = 392d;

            // Act.
            var result = input.FromFahrenheit().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_double_extension_from_and_to_kelvin_returns_correct_double_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.FromKelvin().ToKelvin();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Kelvin

        #region From Gas

        [Fact]
        public void Test_double_extension_from_gas_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const double expected = 473.15d;
            var input = 6d;

            // Act.
            var result = input.FromGas().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas
    }
}
