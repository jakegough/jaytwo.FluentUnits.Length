﻿using System;
using Xunit;

namespace jaytwo.FluentUnits.Tests
{
    // as defined in the NSIT Handbook 44
    // https://nvlpubs.nist.gov/nistpubs/hb/2019/NIST.HB.44-2019.pdf
    // test cases from page C-8

    public class LengthTests
    {
        [Fact]
        public void Inches()
        {
            // arrange
            var length = Length.FromMeters(1);

            // act
            var result = length.Inches;

            // assert
            Assert.Equal(39.37008m, result, 5);
        }

        [Fact]
        public void Feet()
        {
            // arrange
            var length = Length.FromMeters(1);

            // act
            var result = length.Feet;

            // assert
            Assert.Equal(3.280840m, result, 6);
        }

        [Fact]
        public void Yards()
        {
            // arrange
            var length = Length.FromMeters(1);

            // act
            var result = length.Yards;

            // assert
            Assert.Equal(1.093613m, result, 6);
        }

        [Fact]
        public void Miles()
        {
            // arrange
            var length = Length.FromMeters(1);

            // act
            var result = length.Miles;

            // assert
            Assert.Equal(0.0006213712m, result, 8);
        }

        [Fact]
        public void Millimeters()
        {
            // arrange
            var length = Length.FromMeters(1);

            // act
            var result = length.Millimeters;

            // assert
            Assert.Equal(1000, result);
        }

        [Fact]
        public void Centimeters()
        {
            // arrange
            var length = Length.FromMeters(1);

            // act
            var result = length.Centimeters;

            // assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void Meters()
        {
            // arrange
            var length = Length.FromMeters(1);

            // act
            var result = length.Meters;

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Kilometers()
        {
            // arrange
            var length = Length.FromMeters(1000);

            // act
            var result = length.Kilometers;

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void FromMillimeters_overloads()
        {
            // arrange
            var metersPerMillimeter = .001m;

            // act & assert
            Assert.Equal(metersPerMillimeter, Length.FromMillimeters(1m).Meters);
            Assert.Equal(metersPerMillimeter, Length.FromMillimeters(1d).Meters);
            Assert.Equal(metersPerMillimeter, Length.FromMillimeters(1f).Meters);
            Assert.Equal(metersPerMillimeter, Length.FromMillimeters(1).Meters);
            Assert.Equal(metersPerMillimeter, Length.FromMillimeters(1L).Meters);
        }

        [Theory]
        [InlineData(1, .001)]
        [InlineData(1000, 1)]
        public void FromMillimeters(double millimeters, double expectedMeters)
        {
            // arrange

            // act
            var length = Length.FromMillimeters(millimeters);

            // assert
            Assert.Equal(Convert.ToDecimal(expectedMeters), length.Meters);
        }

        [Fact]
        public void FromCentimeters_overloads()
        {
            // arrange
            var metersPerCentimeter = .01m;

            // act & assert
            Assert.Equal(metersPerCentimeter, Length.FromCentimeters(1m).Meters);
            Assert.Equal(metersPerCentimeter, Length.FromCentimeters(1d).Meters);
            Assert.Equal(metersPerCentimeter, Length.FromCentimeters(1f).Meters);
            Assert.Equal(metersPerCentimeter, Length.FromCentimeters(1).Meters);
            Assert.Equal(metersPerCentimeter, Length.FromCentimeters(1L).Meters);
        }

        [Theory]
        [InlineData(1, .01)]
        [InlineData(100, 1)]
        public void FromCentimeters(double centimeters, double expectedMeters)
        {
            // arrange

            // act
            var length = Length.FromCentimeters(centimeters);

            // assert
            Assert.Equal(Convert.ToDecimal(expectedMeters), length.Meters);
        }


        [Fact]
        public void FromMeters_overloads()
        {
            // arrange
            var metersPerMeter = 1m;

            // act & assert
            Assert.Equal(metersPerMeter, Length.FromMeters(1m).Meters);
            Assert.Equal(metersPerMeter, Length.FromMeters(1d).Meters);
            Assert.Equal(metersPerMeter, Length.FromMeters(1f).Meters);
            Assert.Equal(metersPerMeter, Length.FromMeters(1).Meters);
            Assert.Equal(metersPerMeter, Length.FromMeters(1L).Meters);
        }

        [Theory]
        [InlineData(1, 1)]
        public void FromMeters(double meters, double expectedMeters)
        {
            // arrange

            // act
            var length = Length.FromMeters(meters);

            // assert
            Assert.Equal(Convert.ToDecimal(expectedMeters), length.Meters);
        }

        [Fact]
        public void FromKilometers_overloads()
        {
            // arrange
            var metersPerKilometer = 1000m;

            // act & assert
            Assert.Equal(metersPerKilometer, Length.FromKilometers(1m).Meters);
            Assert.Equal(metersPerKilometer, Length.FromKilometers(1d).Meters);
            Assert.Equal(metersPerKilometer, Length.FromKilometers(1f).Meters);
            Assert.Equal(metersPerKilometer, Length.FromKilometers(1).Meters);
            Assert.Equal(metersPerKilometer, Length.FromKilometers(1L).Meters);
        }

        [Theory]
        [InlineData(1, 1000)]
        [InlineData(.001, 1)]
        public void FromKilometers(double kilometers, double expectedMeters)
        {
            // arrange

            // act
            var length = Length.FromKilometers(kilometers);

            // assert
            Assert.Equal(Convert.ToDecimal(expectedMeters), length.Meters);
        }

        [Fact]
        public void FromInches_overloads()
        {
            // arrange
            var metersPerInch = .0254m;

            // act & assert
            Assert.Equal(metersPerInch, Length.FromInches(1m).Meters);
            Assert.Equal(metersPerInch, Length.FromInches(1d).Meters);
            Assert.Equal(metersPerInch, Length.FromInches(1f).Meters);
            Assert.Equal(metersPerInch, Length.FromInches(1).Meters);
            Assert.Equal(metersPerInch, Length.FromInches(1L).Meters);
        }

        [Theory]
        [InlineData(1, .0254)]
        [InlineData(39.37008, 1)]
        public void FromInches(double inches, double expectedMeters)
        {
            // arrange

            // act
            var length = Length.FromInches(inches);

            // assert
            Assert.Equal(Convert.ToDecimal(expectedMeters), length.Meters, 6);
        }

        [Fact]
        public void FromFeet_overloads()
        {
            // arrange
            var metersPerFoot = 0.3048m;

            // act & assert
            Assert.Equal(metersPerFoot, Length.FromFeet(1m).Meters);
            Assert.Equal(metersPerFoot, Length.FromFeet(1d).Meters);
            Assert.Equal(metersPerFoot, Length.FromFeet(1f).Meters);
            Assert.Equal(metersPerFoot, Length.FromFeet(1).Meters);
            Assert.Equal(metersPerFoot, Length.FromFeet(1L).Meters);
        }

        [Theory]
        [InlineData(1, 0.3048)]
        [InlineData(3.280840, 1)]
        public void FromFeet(double feet, double expectedMeters)
        {
            // arrange
            
            // act
            var length = Length.FromFeet(feet);

            // assert
            Assert.Equal(Convert.ToDecimal(expectedMeters), length.Meters, 6);
        }

        [Fact]
        public void FromYards_overloads()
        {
            // arrange
            var metersPerYard = 0.9144m;

            // act & assert
            Assert.Equal(metersPerYard, Length.FromYards(1m).Meters);
            Assert.Equal(metersPerYard, Length.FromYards(1d).Meters);
            Assert.Equal(metersPerYard, Length.FromYards(1f).Meters);
            Assert.Equal(metersPerYard, Length.FromYards(1).Meters);
            Assert.Equal(metersPerYard, Length.FromYards(1L).Meters);
        }

        [Theory]
        [InlineData(1, 0.9144)]
        [InlineData(1.093613, 1)]
        public void FromYards(double yards, double expectedMeters)
        {
            // arrange

            // act
            var length = Length.FromYards(yards);

            // assert
            Assert.Equal(Convert.ToDecimal(expectedMeters), length.Meters, 6);
        }

        [Fact]
        public void FromMiles_overloads()
        {
            // arrange
            var metersPerMile = 1609.344m;

            // act & assert
            Assert.Equal(metersPerMile, Length.FromMiles(1m).Meters);
            Assert.Equal(metersPerMile, Length.FromMiles(1d).Meters);
            Assert.Equal(metersPerMile, Length.FromMiles(1f).Meters);
            Assert.Equal(metersPerMile, Length.FromMiles(1).Meters);
            Assert.Equal(metersPerMile, Length.FromMiles(1L).Meters);
        }

        [Theory]
        [InlineData(1, 1609.344)]
        [InlineData(0.0006213712, 1)]
        public void FromMiles(double miles, double expectedMeters)
        {
            // arrange

            // act
            var length = Length.FromMiles(miles);

            // assert
            Assert.Equal(Convert.ToDecimal(expectedMeters), length.Meters, 6);
        }

        [Fact]
        public void Operator_Multiply()
        {
            // arrange
            var length = Length.FromMeters(2.2);
            
            // assert
            Assert.Equal(1.1m, (length * 0.5m).Meters);
            Assert.Equal(1.1m, (length * 0.5d).Meters);
            Assert.Equal(1.1m, (length * 0.5f).Meters);
            Assert.Equal(4.4m, (length * 2).Meters);
            Assert.Equal(4.4m, (length * 2L).Meters);
        }

        [Fact]
        public void Operator_Divide_overloads()
        {
            // arrange
            var length = Length.FromMeters(2.2);

            // assert
            Assert.Equal(4.4m, (length / 0.5m).Meters);
            Assert.Equal(4.4m, (length / 0.5d).Meters);
            Assert.Equal(4.4m, (length / 0.5f).Meters);
            Assert.Equal(1.1m, (length / 2).Meters);
            Assert.Equal(1.1m, (length / 2L).Meters);
        }

        [Theory]
        [InlineData(2, 1, 3)]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        public void Operator_Add(double left, double right, double expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);
            var expectedLength = Length.FromMeters(expectedResult);

            // act
            var result = leftLength + rightLength;

            // assert
            Assert.Equal(expectedLength, result);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(1, 2, -1)]
        public void Operator_Subtract(double left, double right, double expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);
            var expectedLength = Length.FromMeters(expectedResult);

            // act
            var result = leftLength - rightLength;

            // assert
            Assert.Equal(expectedLength, result);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(1, 1, false)]
        [InlineData(1, 2, false)]
        public void Operator_GreaterThan(double left, double right, bool expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);

            // act
            var result = leftLength > rightLength;

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(1, 1, true)]
        [InlineData(1, 2, false)]
        public void Operator_GreaterThanOrEqual(double left, double right, bool expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);

            // act
            var result = leftLength >= rightLength;

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(1, 1, false)]
        [InlineData(1, 2, true)]
        public void Operator_LessThan(double left, double right, bool expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);

            // act
            var result = leftLength < rightLength;

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(1, 1, true)]
        [InlineData(1, 2, true)]
        public void Operator_LessThanOrEqual(double left, double right, bool expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);

            // act
            var result = leftLength <= rightLength;

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(1, 1, true)]
        [InlineData(1, 2, false)]
        public void Operator_EqualTo(double left, double right, bool expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);

            // act
            var result = leftLength == rightLength;

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(1, 1, false)]
        [InlineData(1, 2, true)]
        public void Operator_NotEqual(double left, double right, bool expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);

            // act
            var result = leftLength != rightLength;

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Operator_ToDecimal()
        {
            // arrange

            // act
            decimal asDecimal = Length.FromMeters(1.1);

            // assert
            Assert.Equal(1.1m, asDecimal);
        }

        [Fact]
        public void Operator_FromDecimal()
        {
            // arrange

            // act
            Length asLength = 1.1m;

            // assert
            Assert.Equal(1.1m, asLength.Meters);
        }

        [Fact]
        public void Operator_ToDouble()
        {
            // arrange

            // act
            double asDouble = Length.FromMeters(1.1);

            // assert
            Assert.Equal(1.1d, asDouble);
        }

        [Fact]
        public void Operator_FromDouble()
        {
            // arrange

            // act
            Length asLength = 1.1d;

            // assert
            Assert.Equal(1.1m, asLength.Meters);
        }

        [Fact]
        public void Operator_ToLong()
        {
            // arrange

            // act
            long asLong = Length.FromMeters(5);

            // assert
            Assert.Equal(5L, asLong);
        }

        [Fact]
        public void Operator_FromLong()
        {
            // arrange

            // act
            Length asLength = 5L;

            // assert
            Assert.Equal(5m, asLength.Meters);
        }

        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(1, 1, true)]
        [InlineData(1, 2, false)]
        public void Equals_Length(double left, double right, bool expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);

            // act
            var result = leftLength.Equals(rightLength);

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Equals_Null()
        {
            // arrange
            var left = Length.FromMeters(1);
            object right = null;

            // act
            var result = left.Equals(right);
            
            // assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(1, 2, -1)]
        public void CompareTo_Length(double left, double right, int expectedResult)
        {
            // arrange
            var leftLength = Length.FromMeters(left);
            var rightLength = Length.FromMeters(right);

            // act
            var result = leftLength.CompareTo(rightLength);

            // assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MinValue()
        {
            // assert
            Assert.Equal(decimal.MinValue, Length.MinValue.Meters);
        }

        [Fact]
        public void MaxValue()
        {
            // assert
            Assert.Equal(decimal.MaxValue, Length.MaxValue.Meters);
        }

        [Fact]
        public void Zero()
        {
            // assert
            Assert.Equal(0m, Length.Zero.Meters);
        }
    }
}
