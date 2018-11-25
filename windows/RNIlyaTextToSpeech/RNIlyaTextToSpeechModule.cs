using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Ilya.Text.To.Speech.RNIlyaTextToSpeech
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNIlyaTextToSpeechModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNIlyaTextToSpeechModule"/>.
        /// </summary>
        internal RNIlyaTextToSpeechModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNIlyaTextToSpeech";
            }
        }
    }
}
