// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Settings used for training the model.
    /// For more information on the available settings please visit the official documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
    /// </summary>
    public partial class ImageModelSettings
    {
        /// <summary> Initializes a new instance of ImageModelSettings. </summary>
        public ImageModelSettings()
        {
        }

        /// <summary> Initializes a new instance of ImageModelSettings. </summary>
        /// <param name="advancedSettings"> Settings for advanced scenarios. </param>
        /// <param name="amsGradient"> Enable AMSGrad when optimizer is &apos;adam&apos; or &apos;adamw&apos;. </param>
        /// <param name="augmentations"> Settings for using Augmentations. </param>
        /// <param name="beta1"> Value of &apos;beta1&apos; when optimizer is &apos;adam&apos; or &apos;adamw&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="beta2"> Value of &apos;beta2&apos; when optimizer is &apos;adam&apos; or &apos;adamw&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="checkpointFrequency"> Frequency to store model checkpoints. Must be a positive integer. </param>
        /// <param name="checkpointModel"> The pretrained checkpoint model for incremental training. </param>
        /// <param name="checkpointRunId"> The id of a previous run that has a pretrained checkpoint for incremental training. </param>
        /// <param name="distributed"> Whether to use distributed training. </param>
        /// <param name="earlyStopping"> Enable early stopping logic during training. </param>
        /// <param name="earlyStoppingDelay">
        /// Minimum number of epochs or validation evaluations to wait before primary metric improvement
        /// is tracked for early stopping. Must be a positive integer.
        /// </param>
        /// <param name="earlyStoppingPatience">
        /// Minimum number of epochs or validation evaluations with no primary metric improvement before
        /// the run is stopped. Must be a positive integer.
        /// </param>
        /// <param name="enableOnnxNormalization"> Enable normalization when exporting ONNX model. </param>
        /// <param name="evaluationFrequency"> Frequency to evaluate validation dataset to get metric scores. Must be a positive integer. </param>
        /// <param name="gradientAccumulationStep">
        /// Gradient accumulation means running a configured number of &quot;GradAccumulationStep&quot; steps without
        /// updating the model weights while accumulating the gradients of those steps, and then using
        /// the accumulated gradients to compute the weight updates. Must be a positive integer.
        /// </param>
        /// <param name="layersToFreeze">
        /// Number of layers to freeze for the model. Must be a positive integer.
        /// For instance, passing 2 as value for &apos;seresnext&apos; means
        /// freezing layer0 and layer1. For a full list of models supported and details on layer freeze, please
        /// see: https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="learningRate"> Initial learning rate. Must be a float in the range [0, 1]. </param>
        /// <param name="learningRateScheduler"> Type of learning rate scheduler. Must be &apos;warmup_cosine&apos; or &apos;step&apos;. </param>
        /// <param name="modelName">
        /// Name of the model to use for training.
        /// For more information on the available models please visit the official documentation:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="momentum"> Value of momentum when optimizer is &apos;sgd&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="nesterov"> Enable nesterov when optimizer is &apos;sgd&apos;. </param>
        /// <param name="numberOfEpochs"> Number of training epochs. Must be a positive integer. </param>
        /// <param name="numberOfWorkers"> Number of data loader workers. Must be a non-negative integer. </param>
        /// <param name="optimizer"> Type of optimizer. </param>
        /// <param name="randomSeed"> Random seed to be used when using deterministic training. </param>
        /// <param name="stepLRGamma"> Value of gamma when learning rate scheduler is &apos;step&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="stepLRStepSize"> Value of step size when learning rate scheduler is &apos;step&apos;. Must be a positive integer. </param>
        /// <param name="trainingBatchSize"> Training batch size. Must be a positive integer. </param>
        /// <param name="validationBatchSize"> Validation batch size. Must be a positive integer. </param>
        /// <param name="warmupCosineLRCycles"> Value of cosine cycle when learning rate scheduler is &apos;warmup_cosine&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="warmupCosineLRWarmupEpochs"> Value of warmup epochs when learning rate scheduler is &apos;warmup_cosine&apos;. Must be a positive integer. </param>
        /// <param name="weightDecay"> Value of weight decay when optimizer is &apos;sgd&apos;, &apos;adam&apos;, or &apos;adamw&apos;. Must be a float in the range[0, 1]. </param>
        internal ImageModelSettings(string advancedSettings, bool? amsGradient, string augmentations, float? beta1, float? beta2, int? checkpointFrequency, MachineLearningFlowModelJobInput checkpointModel, string checkpointRunId, bool? distributed, bool? earlyStopping, int? earlyStoppingDelay, int? earlyStoppingPatience, bool? enableOnnxNormalization, int? evaluationFrequency, int? gradientAccumulationStep, int? layersToFreeze, float? learningRate, LearningRateScheduler? learningRateScheduler, string modelName, float? momentum, bool? nesterov, int? numberOfEpochs, int? numberOfWorkers, StochasticOptimizer? optimizer, int? randomSeed, float? stepLRGamma, int? stepLRStepSize, int? trainingBatchSize, int? validationBatchSize, float? warmupCosineLRCycles, int? warmupCosineLRWarmupEpochs, float? weightDecay)
        {
            AdvancedSettings = advancedSettings;
            AmsGradient = amsGradient;
            Augmentations = augmentations;
            Beta1 = beta1;
            Beta2 = beta2;
            CheckpointFrequency = checkpointFrequency;
            CheckpointModel = checkpointModel;
            CheckpointRunId = checkpointRunId;
            Distributed = distributed;
            EarlyStopping = earlyStopping;
            EarlyStoppingDelay = earlyStoppingDelay;
            EarlyStoppingPatience = earlyStoppingPatience;
            EnableOnnxNormalization = enableOnnxNormalization;
            EvaluationFrequency = evaluationFrequency;
            GradientAccumulationStep = gradientAccumulationStep;
            LayersToFreeze = layersToFreeze;
            LearningRate = learningRate;
            LearningRateScheduler = learningRateScheduler;
            ModelName = modelName;
            Momentum = momentum;
            Nesterov = nesterov;
            NumberOfEpochs = numberOfEpochs;
            NumberOfWorkers = numberOfWorkers;
            Optimizer = optimizer;
            RandomSeed = randomSeed;
            StepLRGamma = stepLRGamma;
            StepLRStepSize = stepLRStepSize;
            TrainingBatchSize = trainingBatchSize;
            ValidationBatchSize = validationBatchSize;
            WarmupCosineLRCycles = warmupCosineLRCycles;
            WarmupCosineLRWarmupEpochs = warmupCosineLRWarmupEpochs;
            WeightDecay = weightDecay;
        }

        /// <summary> Settings for advanced scenarios. </summary>
        public string AdvancedSettings { get; set; }
        /// <summary> Enable AMSGrad when optimizer is &apos;adam&apos; or &apos;adamw&apos;. </summary>
        public bool? AmsGradient { get; set; }
        /// <summary> Settings for using Augmentations. </summary>
        public string Augmentations { get; set; }
        /// <summary> Value of &apos;beta1&apos; when optimizer is &apos;adam&apos; or &apos;adamw&apos;. Must be a float in the range [0, 1]. </summary>
        public float? Beta1 { get; set; }
        /// <summary> Value of &apos;beta2&apos; when optimizer is &apos;adam&apos; or &apos;adamw&apos;. Must be a float in the range [0, 1]. </summary>
        public float? Beta2 { get; set; }
        /// <summary> Frequency to store model checkpoints. Must be a positive integer. </summary>
        public int? CheckpointFrequency { get; set; }
        /// <summary> The pretrained checkpoint model for incremental training. </summary>
        public MachineLearningFlowModelJobInput CheckpointModel { get; set; }
        /// <summary> The id of a previous run that has a pretrained checkpoint for incremental training. </summary>
        public string CheckpointRunId { get; set; }
        /// <summary> Whether to use distributed training. </summary>
        public bool? Distributed { get; set; }
        /// <summary> Enable early stopping logic during training. </summary>
        public bool? EarlyStopping { get; set; }
        /// <summary>
        /// Minimum number of epochs or validation evaluations to wait before primary metric improvement
        /// is tracked for early stopping. Must be a positive integer.
        /// </summary>
        public int? EarlyStoppingDelay { get; set; }
        /// <summary>
        /// Minimum number of epochs or validation evaluations with no primary metric improvement before
        /// the run is stopped. Must be a positive integer.
        /// </summary>
        public int? EarlyStoppingPatience { get; set; }
        /// <summary> Enable normalization when exporting ONNX model. </summary>
        public bool? EnableOnnxNormalization { get; set; }
        /// <summary> Frequency to evaluate validation dataset to get metric scores. Must be a positive integer. </summary>
        public int? EvaluationFrequency { get; set; }
        /// <summary>
        /// Gradient accumulation means running a configured number of &quot;GradAccumulationStep&quot; steps without
        /// updating the model weights while accumulating the gradients of those steps, and then using
        /// the accumulated gradients to compute the weight updates. Must be a positive integer.
        /// </summary>
        public int? GradientAccumulationStep { get; set; }
        /// <summary>
        /// Number of layers to freeze for the model. Must be a positive integer.
        /// For instance, passing 2 as value for &apos;seresnext&apos; means
        /// freezing layer0 and layer1. For a full list of models supported and details on layer freeze, please
        /// see: https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </summary>
        public int? LayersToFreeze { get; set; }
        /// <summary> Initial learning rate. Must be a float in the range [0, 1]. </summary>
        public float? LearningRate { get; set; }
        /// <summary> Type of learning rate scheduler. Must be &apos;warmup_cosine&apos; or &apos;step&apos;. </summary>
        public LearningRateScheduler? LearningRateScheduler { get; set; }
        /// <summary>
        /// Name of the model to use for training.
        /// For more information on the available models please visit the official documentation:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </summary>
        public string ModelName { get; set; }
        /// <summary> Value of momentum when optimizer is &apos;sgd&apos;. Must be a float in the range [0, 1]. </summary>
        public float? Momentum { get; set; }
        /// <summary> Enable nesterov when optimizer is &apos;sgd&apos;. </summary>
        public bool? Nesterov { get; set; }
        /// <summary> Number of training epochs. Must be a positive integer. </summary>
        public int? NumberOfEpochs { get; set; }
        /// <summary> Number of data loader workers. Must be a non-negative integer. </summary>
        public int? NumberOfWorkers { get; set; }
        /// <summary> Type of optimizer. </summary>
        public StochasticOptimizer? Optimizer { get; set; }
        /// <summary> Random seed to be used when using deterministic training. </summary>
        public int? RandomSeed { get; set; }
        /// <summary> Value of gamma when learning rate scheduler is &apos;step&apos;. Must be a float in the range [0, 1]. </summary>
        public float? StepLRGamma { get; set; }
        /// <summary> Value of step size when learning rate scheduler is &apos;step&apos;. Must be a positive integer. </summary>
        public int? StepLRStepSize { get; set; }
        /// <summary> Training batch size. Must be a positive integer. </summary>
        public int? TrainingBatchSize { get; set; }
        /// <summary> Validation batch size. Must be a positive integer. </summary>
        public int? ValidationBatchSize { get; set; }
        /// <summary> Value of cosine cycle when learning rate scheduler is &apos;warmup_cosine&apos;. Must be a float in the range [0, 1]. </summary>
        public float? WarmupCosineLRCycles { get; set; }
        /// <summary> Value of warmup epochs when learning rate scheduler is &apos;warmup_cosine&apos;. Must be a positive integer. </summary>
        public int? WarmupCosineLRWarmupEpochs { get; set; }
        /// <summary> Value of weight decay when optimizer is &apos;sgd&apos;, &apos;adam&apos;, or &apos;adamw&apos;. Must be a float in the range[0, 1]. </summary>
        public float? WeightDecay { get; set; }
    }
}
