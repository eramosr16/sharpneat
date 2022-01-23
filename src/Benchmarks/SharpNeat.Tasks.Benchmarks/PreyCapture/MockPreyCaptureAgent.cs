﻿using System;
using SharpNeat.BlackBox;

namespace SharpNeatTasks.Benchmarks.PreyCapture
{
    sealed internal class MockPreyCaptureAgent : IBlackBox<double>
    {
        readonly double[] _outputArr;
        int _state;

        #region Constructor

        public MockPreyCaptureAgent()
        {
            this.Inputs = new double[14];
            _outputArr = new double[4];
            this.Outputs = new VectorSegment<double>(_outputArr, 0, 4);
        }

        #endregion

        #region IBlackBox

        public Memory<double> Inputs { get; }

        public IVector<double> Outputs { get; }

        public void Activate()
        {
            // Make the agent run around in a tight circle.
            _outputArr[_state] = 1.0;
            if(++_state == 4)
            {
                _state = 0;
            }
        }

        public void ResetState()
        {
            Array.Clear(_outputArr, 0, _outputArr.Length);
        }

        #endregion

        #region IDisposable

        /// <summary>
        /// Releases both managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
        }

        #endregion
    }
}
