# CMPM163Labs

Lab 2 Video: https://drive.google.com/file/d/176isAq8VgUBeeHbjlNLlYNKg6hYGG6DS/view?usp=sharing

![](Lab2Objects.png)

Lab 3 Video: https://drive.google.com/file/d/1tHqgdTgH8mQt6PhxtHRgjFxgl-9zJmkH/view?usp=sharing

The first cube has a "Normal" material, which appears to be a maxed out color on each side of RGB.  This means that it doesn't take a color as an input, but I did set "flatShading" to true.  It doesn't appear to change the box much though.
The second cube is the basic Phong model that was given in Part1 of this lab.  I left it unchanged.
The third cube is the example rendering cube.  I also left it unchanged.
The fourth cube is the rendered cube with the same vertexShader as the third, but with a different framentShader.  The only difference is that I changed the "vUv" to have a ".x" ending, which changed the side that the shader starts from. Then, during the html loading, I changed the colors to pink and lighter pink.

Lab 4 Video: https://drive.google.com/file/d/1-dAu9BOkkr7nu4BSDN_J2Gj70S4-8HRr/view?usp=sharing

My first three cubes are all slightly angled to show how the lighting moves in more detail.
Cube 1 is the leftmost one in the top row.  It uses the built in THREE.js textures, loading a jpg without a normMap. This leaves it flat on all sides<br/>
Cube 2 is the middle one in the top row.  This has the addition of the normMap, which is highlighted through the lighting moving side to side.<br/>
Cube 3 is the right one in the top row.  It has a different norm map than its image.  All of these have the norm map and image placed in a Phong material before being placed onto the cube through a THREE Mesh.<br/>
Cube 4 is the cube on the right in the bottom row.  It doesn't use the THREE.js shaders, instead using the fragment and vertex shaders loaded in the shaders folder.  These are loaded in the script and then added to create a basic THREE.js mesh.  It doesn't need the Phong mesh like the other cubes because of the shaders that are added to the material beforehand.<br/>
Cube 5 uses the same process as 4 of using our own shaders to create a material that is added to the cube geometry to make a mesh.  However, the shaders are slightly changed to achieve the tiling effect.  Here, I used the "mod" function on the vUv vector in the fragment shader with a float of 1.0, and multipled the vUv vector in the vertex shader by 2.0.  The vertex shader change compresses the texture because each pixel is reading twice as far as it should, which is why when the fragment shader is not enabled it appears to be stretched over the cube.  The fragment shader, when enabled with the mod 1.0, makes it so instead of stretching the last color over the rest of the cube because of an out of bounds read, reads the original image a second time because the modulo returns a number that is again in bounds of the original image.<br/>
Question 24 answers:<br/>
A) x = 8 * u<br/>
B) y = -8v + 8<br/>
C) blue<br/>


Lab 5: https://drive.google.com/file/d/14h9_NmOHkwZoPa7grE9mUKvLv8vpf34j/view?usp=sharing <br/>
For my cart game, I changed the body of the kart into a more metallic color, by increasing both the "metallic" and "smoothness" values.  My particles come from both wheels, aimed in a low, behind the wheel position instead of the high arch from side in the example.  Next, I replaced my checkpoints with coins, with the coin model from https://www.cgtrader.com/items/834842/download-page.  There are 10 in all.  Then I used the extra track on the side to expand the track, using the inclined turns and copying the old pieces.  Finally, the ramp material was changed to be a transparent amber color through the "UI/Lit/Transparent" shader with a red tint, because the setting sun gives off a red color as well.
