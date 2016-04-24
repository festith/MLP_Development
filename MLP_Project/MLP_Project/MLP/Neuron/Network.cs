namespace MLP_Network
{
    public class Network
    {

        /// <summary>
        /// Get array of layers of network
        /// </summary>
        public Layer[] Layers { get; private set; }

        /// <summary>
        /// Initia;ize a new instance of the Network class.
        /// </summary>
        /// <param name="activationFunction"> Activation function. </param>
        public Network(IFunction activationFunction)
        {
            CreateLayers(activationFunction);
        }

        /// <summary>
        /// Compute output vector by input vector
        /// </summary>
        /// <param name="inputVector">Input vector (double[])</param>
        /// <returns>Output vector (double[])</returns>
        public float[] ComputeOutput(float[] inputVector)
        {

        }

        private void CreateLayers(IFunction activationFunction)
        {

        }

    }
}
