namespace MLP_Network
{
    public interface ILearningMethod
    {
        /// <summary>
        /// Gets the learning kf.
        float Alfa { get; }

        /// <summary>
        /// Calculates the new weight between neurons.
        /// </summary>
        /// <param name="w">Current weight value.</param>
        /// <param name="leftValue">The left neuron value.</param>
        /// <param name="rightValue">The right neuron value.</param>
        float CalculateWeight(float w, float leftValue, float rightValue);
    }
}
