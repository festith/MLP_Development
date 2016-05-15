namespace MLP_Network
{
    /// <summary>
    /// Signal Hebb's method implementation.
    /// </summary>
    public class HebbMethod
    {
        /// <summary>
        /// Gets the learning kf.
        /// </summary>
        public float Alfa { get; private set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="HebbMethod"/> class.
        /// </summary>
        /// <param name="alfa"> The learning kf. </param>
        public HebbMethod(float alfa)
        {
            Alfa = alfa;
        }

        /// <summary>
        /// Calculates the new weight between neurons.
        /// </summary>
        /// <param name="w">Current weight value.</param>
        /// <param name="leftValue">The left neuron value.</param>
        /// <param name="rightValue">The right neuron value.</param>
        /// <returns></returns>
        public float CalculateWeight(float w, float leftValue, float rightValue)
        {
            return w + Alfa*leftValue*rightValue;
        }
    }
}
