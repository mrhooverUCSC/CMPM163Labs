uniform vec3 colorA;
uniform vec3 colorB;
varying vec3 vUv;

void main() {
  gl_FragColor = vec4(mix(colorA, colorB, vUv.x), 1.0);
}

