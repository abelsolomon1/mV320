﻿namespace StrategyPattern {
    internal class HighContrastFilter : IFilter {
        public void Apply(string fileName) {
            Console.WriteLine($"Applying high contrast filter on {fileName}...");
        }
    }
}
