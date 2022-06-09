﻿using SharpNeat.Experiments.ConfigModels;

namespace SharpNeat.Tasks.PreyCapture.ConfigModels;

/// <summary>
/// Model type for prey capture experiment configuration.
/// </summary>
public class PreyCaptureExperimentConfig : ExperimentConfig
{
    /// <summary>
    /// Custom config for the prey capture experiment.
    /// </summary>
    public PreyCaptureCustomConfig? CustomEvaluationSchemeConfig { get; set; }
}
