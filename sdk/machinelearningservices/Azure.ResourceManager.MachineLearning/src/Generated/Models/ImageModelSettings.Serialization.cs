// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageModelSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AdvancedSettings))
            {
                if (AdvancedSettings != null)
                {
                    writer.WritePropertyName("advancedSettings"u8);
                    writer.WriteStringValue(AdvancedSettings);
                }
                else
                {
                    writer.WriteNull("advancedSettings");
                }
            }
            if (Optional.IsDefined(AmsGradient))
            {
                if (AmsGradient != null)
                {
                    writer.WritePropertyName("amsGradient"u8);
                    writer.WriteBooleanValue(AmsGradient.Value);
                }
                else
                {
                    writer.WriteNull("amsGradient");
                }
            }
            if (Optional.IsDefined(Augmentations))
            {
                if (Augmentations != null)
                {
                    writer.WritePropertyName("augmentations"u8);
                    writer.WriteStringValue(Augmentations);
                }
                else
                {
                    writer.WriteNull("augmentations");
                }
            }
            if (Optional.IsDefined(Beta1))
            {
                if (Beta1 != null)
                {
                    writer.WritePropertyName("beta1"u8);
                    writer.WriteNumberValue(Beta1.Value);
                }
                else
                {
                    writer.WriteNull("beta1");
                }
            }
            if (Optional.IsDefined(Beta2))
            {
                if (Beta2 != null)
                {
                    writer.WritePropertyName("beta2"u8);
                    writer.WriteNumberValue(Beta2.Value);
                }
                else
                {
                    writer.WriteNull("beta2");
                }
            }
            if (Optional.IsDefined(CheckpointFrequency))
            {
                if (CheckpointFrequency != null)
                {
                    writer.WritePropertyName("checkpointFrequency"u8);
                    writer.WriteNumberValue(CheckpointFrequency.Value);
                }
                else
                {
                    writer.WriteNull("checkpointFrequency");
                }
            }
            if (Optional.IsDefined(CheckpointModel))
            {
                if (CheckpointModel != null)
                {
                    writer.WritePropertyName("checkpointModel"u8);
                    writer.WriteObjectValue(CheckpointModel);
                }
                else
                {
                    writer.WriteNull("checkpointModel");
                }
            }
            if (Optional.IsDefined(CheckpointRunId))
            {
                if (CheckpointRunId != null)
                {
                    writer.WritePropertyName("checkpointRunId"u8);
                    writer.WriteStringValue(CheckpointRunId);
                }
                else
                {
                    writer.WriteNull("checkpointRunId");
                }
            }
            if (Optional.IsDefined(Distributed))
            {
                if (Distributed != null)
                {
                    writer.WritePropertyName("distributed"u8);
                    writer.WriteBooleanValue(Distributed.Value);
                }
                else
                {
                    writer.WriteNull("distributed");
                }
            }
            if (Optional.IsDefined(EarlyStopping))
            {
                if (EarlyStopping != null)
                {
                    writer.WritePropertyName("earlyStopping"u8);
                    writer.WriteBooleanValue(EarlyStopping.Value);
                }
                else
                {
                    writer.WriteNull("earlyStopping");
                }
            }
            if (Optional.IsDefined(EarlyStoppingDelay))
            {
                if (EarlyStoppingDelay != null)
                {
                    writer.WritePropertyName("earlyStoppingDelay"u8);
                    writer.WriteNumberValue(EarlyStoppingDelay.Value);
                }
                else
                {
                    writer.WriteNull("earlyStoppingDelay");
                }
            }
            if (Optional.IsDefined(EarlyStoppingPatience))
            {
                if (EarlyStoppingPatience != null)
                {
                    writer.WritePropertyName("earlyStoppingPatience"u8);
                    writer.WriteNumberValue(EarlyStoppingPatience.Value);
                }
                else
                {
                    writer.WriteNull("earlyStoppingPatience");
                }
            }
            if (Optional.IsDefined(EnableOnnxNormalization))
            {
                if (EnableOnnxNormalization != null)
                {
                    writer.WritePropertyName("enableOnnxNormalization"u8);
                    writer.WriteBooleanValue(EnableOnnxNormalization.Value);
                }
                else
                {
                    writer.WriteNull("enableOnnxNormalization");
                }
            }
            if (Optional.IsDefined(EvaluationFrequency))
            {
                if (EvaluationFrequency != null)
                {
                    writer.WritePropertyName("evaluationFrequency"u8);
                    writer.WriteNumberValue(EvaluationFrequency.Value);
                }
                else
                {
                    writer.WriteNull("evaluationFrequency");
                }
            }
            if (Optional.IsDefined(GradientAccumulationStep))
            {
                if (GradientAccumulationStep != null)
                {
                    writer.WritePropertyName("gradientAccumulationStep"u8);
                    writer.WriteNumberValue(GradientAccumulationStep.Value);
                }
                else
                {
                    writer.WriteNull("gradientAccumulationStep");
                }
            }
            if (Optional.IsDefined(LayersToFreeze))
            {
                if (LayersToFreeze != null)
                {
                    writer.WritePropertyName("layersToFreeze"u8);
                    writer.WriteNumberValue(LayersToFreeze.Value);
                }
                else
                {
                    writer.WriteNull("layersToFreeze");
                }
            }
            if (Optional.IsDefined(LearningRate))
            {
                if (LearningRate != null)
                {
                    writer.WritePropertyName("learningRate"u8);
                    writer.WriteNumberValue(LearningRate.Value);
                }
                else
                {
                    writer.WriteNull("learningRate");
                }
            }
            if (Optional.IsDefined(LearningRateScheduler))
            {
                writer.WritePropertyName("learningRateScheduler"u8);
                writer.WriteStringValue(LearningRateScheduler.Value.ToString());
            }
            if (Optional.IsDefined(ModelName))
            {
                if (ModelName != null)
                {
                    writer.WritePropertyName("modelName"u8);
                    writer.WriteStringValue(ModelName);
                }
                else
                {
                    writer.WriteNull("modelName");
                }
            }
            if (Optional.IsDefined(Momentum))
            {
                if (Momentum != null)
                {
                    writer.WritePropertyName("momentum"u8);
                    writer.WriteNumberValue(Momentum.Value);
                }
                else
                {
                    writer.WriteNull("momentum");
                }
            }
            if (Optional.IsDefined(Nesterov))
            {
                if (Nesterov != null)
                {
                    writer.WritePropertyName("nesterov"u8);
                    writer.WriteBooleanValue(Nesterov.Value);
                }
                else
                {
                    writer.WriteNull("nesterov");
                }
            }
            if (Optional.IsDefined(NumberOfEpochs))
            {
                if (NumberOfEpochs != null)
                {
                    writer.WritePropertyName("numberOfEpochs"u8);
                    writer.WriteNumberValue(NumberOfEpochs.Value);
                }
                else
                {
                    writer.WriteNull("numberOfEpochs");
                }
            }
            if (Optional.IsDefined(NumberOfWorkers))
            {
                if (NumberOfWorkers != null)
                {
                    writer.WritePropertyName("numberOfWorkers"u8);
                    writer.WriteNumberValue(NumberOfWorkers.Value);
                }
                else
                {
                    writer.WriteNull("numberOfWorkers");
                }
            }
            if (Optional.IsDefined(Optimizer))
            {
                writer.WritePropertyName("optimizer"u8);
                writer.WriteStringValue(Optimizer.Value.ToString());
            }
            if (Optional.IsDefined(RandomSeed))
            {
                if (RandomSeed != null)
                {
                    writer.WritePropertyName("randomSeed"u8);
                    writer.WriteNumberValue(RandomSeed.Value);
                }
                else
                {
                    writer.WriteNull("randomSeed");
                }
            }
            if (Optional.IsDefined(StepLRGamma))
            {
                if (StepLRGamma != null)
                {
                    writer.WritePropertyName("stepLRGamma"u8);
                    writer.WriteNumberValue(StepLRGamma.Value);
                }
                else
                {
                    writer.WriteNull("stepLRGamma");
                }
            }
            if (Optional.IsDefined(StepLRStepSize))
            {
                if (StepLRStepSize != null)
                {
                    writer.WritePropertyName("stepLRStepSize"u8);
                    writer.WriteNumberValue(StepLRStepSize.Value);
                }
                else
                {
                    writer.WriteNull("stepLRStepSize");
                }
            }
            if (Optional.IsDefined(TrainingBatchSize))
            {
                if (TrainingBatchSize != null)
                {
                    writer.WritePropertyName("trainingBatchSize"u8);
                    writer.WriteNumberValue(TrainingBatchSize.Value);
                }
                else
                {
                    writer.WriteNull("trainingBatchSize");
                }
            }
            if (Optional.IsDefined(ValidationBatchSize))
            {
                if (ValidationBatchSize != null)
                {
                    writer.WritePropertyName("validationBatchSize"u8);
                    writer.WriteNumberValue(ValidationBatchSize.Value);
                }
                else
                {
                    writer.WriteNull("validationBatchSize");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRCycles))
            {
                if (WarmupCosineLRCycles != null)
                {
                    writer.WritePropertyName("warmupCosineLRCycles"u8);
                    writer.WriteNumberValue(WarmupCosineLRCycles.Value);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRCycles");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRWarmupEpochs))
            {
                if (WarmupCosineLRWarmupEpochs != null)
                {
                    writer.WritePropertyName("warmupCosineLRWarmupEpochs"u8);
                    writer.WriteNumberValue(WarmupCosineLRWarmupEpochs.Value);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRWarmupEpochs");
                }
            }
            if (Optional.IsDefined(WeightDecay))
            {
                if (WeightDecay != null)
                {
                    writer.WritePropertyName("weightDecay"u8);
                    writer.WriteNumberValue(WeightDecay.Value);
                }
                else
                {
                    writer.WriteNull("weightDecay");
                }
            }
            writer.WriteEndObject();
        }

        internal static ImageModelSettings DeserializeImageModelSettings(JsonElement element)
        {
            Optional<string> advancedSettings = default;
            Optional<bool?> amsGradient = default;
            Optional<string> augmentations = default;
            Optional<float?> beta1 = default;
            Optional<float?> beta2 = default;
            Optional<int?> checkpointFrequency = default;
            Optional<MachineLearningFlowModelJobInput> checkpointModel = default;
            Optional<string> checkpointRunId = default;
            Optional<bool?> distributed = default;
            Optional<bool?> earlyStopping = default;
            Optional<int?> earlyStoppingDelay = default;
            Optional<int?> earlyStoppingPatience = default;
            Optional<bool?> enableOnnxNormalization = default;
            Optional<int?> evaluationFrequency = default;
            Optional<int?> gradientAccumulationStep = default;
            Optional<int?> layersToFreeze = default;
            Optional<float?> learningRate = default;
            Optional<LearningRateScheduler> learningRateScheduler = default;
            Optional<string> modelName = default;
            Optional<float?> momentum = default;
            Optional<bool?> nesterov = default;
            Optional<int?> numberOfEpochs = default;
            Optional<int?> numberOfWorkers = default;
            Optional<StochasticOptimizer> optimizer = default;
            Optional<int?> randomSeed = default;
            Optional<float?> stepLRGamma = default;
            Optional<int?> stepLRStepSize = default;
            Optional<int?> trainingBatchSize = default;
            Optional<int?> validationBatchSize = default;
            Optional<float?> warmupCosineLRCycles = default;
            Optional<int?> warmupCosineLRWarmupEpochs = default;
            Optional<float?> weightDecay = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("advancedSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        advancedSettings = null;
                        continue;
                    }
                    advancedSettings = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amsGradient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        amsGradient = null;
                        continue;
                    }
                    amsGradient = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("augmentations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        augmentations = null;
                        continue;
                    }
                    augmentations = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("beta1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta1 = null;
                        continue;
                    }
                    beta1 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("beta2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta2 = null;
                        continue;
                    }
                    beta2 = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("checkpointFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        checkpointFrequency = null;
                        continue;
                    }
                    checkpointFrequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("checkpointModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        checkpointModel = null;
                        continue;
                    }
                    checkpointModel = MachineLearningFlowModelJobInput.DeserializeMachineLearningFlowModelJobInput(property.Value);
                    continue;
                }
                if (property.NameEquals("checkpointRunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        checkpointRunId = null;
                        continue;
                    }
                    checkpointRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        distributed = null;
                        continue;
                    }
                    distributed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("earlyStopping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStopping = null;
                        continue;
                    }
                    earlyStopping = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("earlyStoppingDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingDelay = null;
                        continue;
                    }
                    earlyStoppingDelay = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("earlyStoppingPatience"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingPatience = null;
                        continue;
                    }
                    earlyStoppingPatience = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableOnnxNormalization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableOnnxNormalization = null;
                        continue;
                    }
                    enableOnnxNormalization = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("evaluationFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        evaluationFrequency = null;
                        continue;
                    }
                    evaluationFrequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("gradientAccumulationStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gradientAccumulationStep = null;
                        continue;
                    }
                    gradientAccumulationStep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("layersToFreeze"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        layersToFreeze = null;
                        continue;
                    }
                    layersToFreeze = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("learningRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRate = null;
                        continue;
                    }
                    learningRate = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("learningRateScheduler"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    learningRateScheduler = new LearningRateScheduler(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelName = null;
                        continue;
                    }
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("momentum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        momentum = null;
                        continue;
                    }
                    momentum = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("nesterov"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nesterov = null;
                        continue;
                    }
                    nesterov = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("numberOfEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfEpochs = null;
                        continue;
                    }
                    numberOfEpochs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfWorkers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfWorkers = null;
                        continue;
                    }
                    numberOfWorkers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("optimizer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    optimizer = new StochasticOptimizer(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("randomSeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        randomSeed = null;
                        continue;
                    }
                    randomSeed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stepLRGamma"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRGamma = null;
                        continue;
                    }
                    stepLRGamma = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("stepLRStepSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRStepSize = null;
                        continue;
                    }
                    stepLRStepSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trainingBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingBatchSize = null;
                        continue;
                    }
                    trainingBatchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validationBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationBatchSize = null;
                        continue;
                    }
                    validationBatchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRCycles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRCycles = null;
                        continue;
                    }
                    warmupCosineLRCycles = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRWarmupEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRWarmupEpochs = null;
                        continue;
                    }
                    warmupCosineLRWarmupEpochs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("weightDecay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightDecay = null;
                        continue;
                    }
                    weightDecay = property.Value.GetSingle();
                    continue;
                }
            }
            return new ImageModelSettings(advancedSettings.Value, Optional.ToNullable(amsGradient), augmentations.Value, Optional.ToNullable(beta1), Optional.ToNullable(beta2), Optional.ToNullable(checkpointFrequency), checkpointModel.Value, checkpointRunId.Value, Optional.ToNullable(distributed), Optional.ToNullable(earlyStopping), Optional.ToNullable(earlyStoppingDelay), Optional.ToNullable(earlyStoppingPatience), Optional.ToNullable(enableOnnxNormalization), Optional.ToNullable(evaluationFrequency), Optional.ToNullable(gradientAccumulationStep), Optional.ToNullable(layersToFreeze), Optional.ToNullable(learningRate), Optional.ToNullable(learningRateScheduler), modelName.Value, Optional.ToNullable(momentum), Optional.ToNullable(nesterov), Optional.ToNullable(numberOfEpochs), Optional.ToNullable(numberOfWorkers), Optional.ToNullable(optimizer), Optional.ToNullable(randomSeed), Optional.ToNullable(stepLRGamma), Optional.ToNullable(stepLRStepSize), Optional.ToNullable(trainingBatchSize), Optional.ToNullable(validationBatchSize), Optional.ToNullable(warmupCosineLRCycles), Optional.ToNullable(warmupCosineLRWarmupEpochs), Optional.ToNullable(weightDecay));
        }
    }
}
