
# react-native-ilya-text-to-speech

## Getting started

`$ npm install react-native-ilya-text-to-speech --save`

### Mostly automatic installation

`$ react-native link react-native-ilya-text-to-speech`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-ilya-text-to-speech` and add `RNIlyaTextToSpeech.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNIlyaTextToSpeech.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNIlyaTextToSpeechPackage;` to the imports at the top of the file
  - Add `new RNIlyaTextToSpeechPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-ilya-text-to-speech'
  	project(':react-native-ilya-text-to-speech').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-ilya-text-to-speech/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-ilya-text-to-speech')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNIlyaTextToSpeech.sln` in `node_modules/react-native-ilya-text-to-speech/windows/RNIlyaTextToSpeech.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Ilya.Text.To.Speech.RNIlyaTextToSpeech;` to the usings at the top of the file
  - Add `new RNIlyaTextToSpeechPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNIlyaTextToSpeech from 'react-native-ilya-text-to-speech';

// TODO: What to do with the module?
RNIlyaTextToSpeech;
```
  