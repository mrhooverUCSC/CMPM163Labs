# CMPM163Labs

Lab 2 Video: https://drive.google.com/file/d/176isAq8VgUBeeHbjlNLlYNKg6hYGG6DS/view?usp=sharing

![](Lab2Objects.png)

Lab 3 Video: https://drive.google.com/file/d/1tHqgdTgH8mQt6PhxtHRgjFxgl-9zJmkH/view?usp=sharing
The first cube has a "Normal" material, which appears to be a maxed out color on each side of RGB.  This means that it doesn't take a color as an input, but I did set "flatShading" to true.  It doesn't appear to change the box much though.
The second cube is the basic Phong model that was given in Part1 of this lab.  I left it unchanged.
The third cube is the example rendering cube.  I also left it unchanged.
The fourth cube is the rendered cube with the same vertexShader as the third, but with a different framentShader.  The only difference is that I changed the "vUv" to have a ".x" ending, which changed the side that the shader starts from. Then, during the html loading, I changed the colors to pink and lighter pink.
