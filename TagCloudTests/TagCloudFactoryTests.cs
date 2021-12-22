﻿using FluentAssertions;
using NUnit.Framework;
using TagsCloudVisualization;

namespace TagCloudTests
{
    [TestFixture]
    public class TagCloudFactoryTests
    {
        private TagCloudFactory factory = new TagCloudFactory();

        [TestCase("sorted")]
        [TestCase("mixed")]
        public void TagCloudFactory_NotThrows(string order)
        {
            var tagCloud = factory.CreateInstance(false, order);
            tagCloud.IsSuccess.Should().BeTrue();
        }
        
        [TestCase("qwery")]
        [TestCase("Mixed")]
        [TestCase("Shuffled")]
        public void TagCloudFactory_UnknownOrder_Throws(string order)
        {
            var tagCloud = factory.CreateInstance(false, order);
            tagCloud.IsSuccess.Should().BeFalse();
        }
    }
}