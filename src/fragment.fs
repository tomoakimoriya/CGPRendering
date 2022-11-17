struct DirectionalLight {
    vec3 direction;
    vec3 color;
};

uniform DirectionalLight directionalLights[ NUM_DIR_LIGHTS ];
uniform vec3 modelcolor;
varying vec3 vnormal;

void main()
{
    float lambert = dot(vnormal, directionalLights[0].direction);
    float half_lambert = pow(lambert * (1.0 / 2.0) + 1.0 / 2.0, 2.0);
    vec3 pcolor = modelcolor * half_lambert;
    gl_FragColor = vec4( pcolor.xyz, 1.0 );
}
