namespace MLP_Network
{
    public class Network
    {

        /// <summary>
        /// Get array of layers of network
        /// </summary>
        public ILayer[] Layers { get; private set; }

        /// <summary>
        /// Initia;ize a new instance of the Network class.
        /// </summary>
        /// <param name="activationFunction"> Activation function. </param>
        public Network(IFunction activationFunction, int inputDimension, int outputDimension)
        {
            CreateLayers(activationFunction, inputDimension, outputDimension);
        }

        /// <summary>
        /// Compute output vector by input vector
        /// </summary>
        /// <param name="inputVector">Input vector (double[])</param>
        /// <returns>Output vector (double[])</returns>
        public float[] ComputeOutput(float[] inputVector)
        {
            float[] output = inputVector;

            foreach (var layer in Layers)
            {
                output = layer.Compute(output);
            }

            return output;
        }

        private void CreateLayers(IFunction activationFunction, int inputDimension, int outputDimension)
        {
            var firstLayer = new FirstLayer(activationFunction);
            var middleLayerNeuronsCout = (inputDimension + outputDimension)/2;
            var middleLayer = new Layer(activationFunction, inputDimension, middleLayerNeuronsCout);
            var finalLayer = new Layer(activationFunction, middleLayerNeuronsCout, outputDimension);

            Layers = new ILayer[] { firstLayer, middleLayer, finalLayer };
        }

    }
}
