﻿using System.Drawing;
using TagsCloudVisualization.Infrastructure;

namespace TagsCloudVisualization.Default
{
    public class SingleTagColor : ITokenColorChooser
    {
        private readonly Color color;

        public SingleTagColor(Color color)
        {
            this.color = color;
        }

        public Color GetTokenColor(Token token)
        {
            return color;
        }
    }
}