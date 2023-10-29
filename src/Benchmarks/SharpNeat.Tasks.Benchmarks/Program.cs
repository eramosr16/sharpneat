﻿using BenchmarkDotNet.Running;
using SharpNeat.Tasks;
using SharpNeat.Tasks.Benchmarks.FunctionRegression;
using SharpNeat.Tasks.Benchmarks.PreyCapture;

namespace SharpNeatTasks.Benchmarks;

sealed class Program
{
    static void Main()
    {
        var summary = BenchmarkRunner.Run<PreyCaptureWorldBenchmark>();

        //var benchmark = new PreyCaptureWorldBenchmark();
        //benchmark.RunTrials();

        //BenchmarkRunner.Run<Tasks.BinarySixMultiplexerEvaluatorBenchmarks>();
        //BenchmarkRunner.Run<Tasks.BinaryElevenMultiplexerEvaluatorBenchmarks>();
        BenchmarkRunner.Run<BinaryTwentyMultiplexerEvaluatorBenchmarks>();
    }
}
