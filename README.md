![GitHub all releases](https://img.shields.io/github/downloads/Artttdez/PastebinPlugin/total)
![GitHub tag (latest by date)](https://img.shields.io/github/v/tag/Artttdez/PastebinPlugin)
# PastebinPlugin
Description
-----------------------------------
You can use this plugin to share parts of your code by Pastebin.com with a few clicks.

Features
-----------------------------------
* Plugin gets selected part of code/text and creates Pastebin.com paste with it.


Building from the source
-----------------------------------
1. Clone the repository using the following command. <br>
   `git clone --recursive https://github.com/Artttdez/PastebinPlugin`
2. Navigate into the cloned repository and run `./gradlew buildPlugin`. In the `build/distributions` directory, `.zip` file with plugin will be created.

Usage
-----------------------------------
1. Go to `IntelliJ IDEA ⟶ Preferences ⟶ Tools ⟶ Pastebin Sender Settings` 
2. Insert your DevKey token from Pastebin.com (to get your DevKey, you should sign up in Pastebin.com and get your DevKey from the link https://pastebin.com/doc_api)
   <br>
   <img src="https://sun9-36.userapi.com/impg/2_erjs_S3dibTsiMFM0GGM-L1mh2L6q410gyJw/guvOnPDo-78.jpg?size=1960x1462&quality=96&sign=9bd131c58af70292875d3b174fa00e21&type=album" width="400px">
3. Hotkeys - `Ctrl+\ Ctrl+P`
4. If the DevKey token is correct, a new folder with your Pastebin.com paste will be opened soon in your default browser. 
5. If something gone wrong, a popup with following message will be shown up:
   <br>
   <img src="https://sun9-65.userapi.com/impg/5pEmU0x2ApbvMHynG6El6FgM8xzX8GgDBBwAAA/Oxh7p9HU4pM.jpg?size=524x418&quality=96&sign=05aee51c1a082890a505cd8211f9cd36&type=album" width="200px">
   <img src="https://sun9-30.userapi.com/impg/CxY_MD3CByCeRwApVLKWOYFRJPLsjxjOQellkQ/G2NXOWYkxVU.jpg?size=524x416&quality=96&sign=002ec0b28930e5179b5f0696afe2d09a&type=album" width="200px">

Installing the plugin to IDEA
-----------------------------------

**From Jetbrains plugin repository (soon)**
1. Go to `IntelliJ IDEA ⟶ Preferences ⟶ Plugins`
2. Select `Browse Repositories` button at the bottom.
3. Search for `Pastebin Sender` using the search. Then you can install the plugin using the `Install` button.
4. Restart IDEA.

**From a local build**
1. Go to `IntelliJ IDEA ⟶ Preferences ⟶ Plugins`
2. Click `Install plugin from disk` button and select the deployed plugin zip file. Please make sure to install the Zip file, not the extracted Jar files.
3. Restart IDEA.