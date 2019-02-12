// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

Shader "Custom/JellyBeanShader"
{
	Properties
	{
		_Color("Color", Color) = (1,1,1,1)
		_Color2("Color 2", Color) = (1,1,1,1)
		_Color3("Color 3", Color) = (1,1,1,1)
		_Color4("Color 4", Color) = (1,1,1,1)
		_NoiseScale("Noise Scale", Range(0, 1000)) = 1.0
		_NoiseScale2("Noise Scale 2", Range(0, 1000)) = 3.0
		_NoiseOffset("Noise Offset", Vector) = (0,0,0,0)
		_Noise2Factor("Strength of Noise 2", Range(0,1)) = 0.3
		_Contrast("Contrast of Smoothness", Range(-5, 5)) = 0
		_Brightness("Brightness of Smoothness", Range(-5, 5)) = 0
		_TangentDst("Tangent lookup distance", Float) = 0
		_NormalStrength("Strength of normal Input", Float) = 1
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows vertex:vert
		#include "Noise/ClassicNoise3D.hlsl"

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0


        struct Input
        {
			float3 worldPos;
			float3 worldNormal; INTERNAL_DATA
			float3 objPos;
			float3 tangent_input;
			float3 binormal_input;
        };

        half _Glossiness;
		half _Glossiness2;
		half _NoiseScale;
		half _NoiseScale2;
		half _Noise2Factor;
		half _Contrast;
		half _Brightness;
		float _TangentDst;
		half _NormalStrength;
		fixed4 _Color;
		fixed4 _Color2;
		fixed4 _Color3;
		fixed4 _Color4;
		fixed4 _NoiseOffset;
		

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)
		
		void vert(inout appdata_tan i, out Input o)
		{
			UNITY_INITIALIZE_OUTPUT(Input, o);
			
			half3 objPos = i.vertex.xyz;

			half4 p_normal = mul(float4(i.normal, 0.0f), unity_WorldToObject);
			half4 p_tangent = mul(unity_ObjectToWorld, i.tangent);

			half3 normal_input = normalize(p_normal.xyz);
			half3 tangent_input = normalize(p_tangent.xyz);
			half3 binormal_input = cross(p_normal.xyz, tangent_input.xyz) * i.tangent.w;

			o.tangent_input = normalize(i.tangent);
			o.binormal_input = normalize(cross(p_normal.xyz, o.tangent_input));
			o.objPos = objPos;
		}

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
			//float3 objPos = mul(unity_WorldToObject, IN.worldPos);
			
			float3 offset = float3(_NoiseOffset.x, _NoiseOffset.y, _NoiseOffset.z);

			float3 objPos = IN.objPos;

			float noise1 = cnoise(objPos * _NoiseScale);
			float pointValue = noise1;
			float noise2 = cnoise((objPos * _NoiseScale2) + offset);
			noise1 = (noise1 + 1) * 0.5 * (1 - _Noise2Factor);
			noise2 = (noise2 + 1) * 0.5 * _Noise2Factor;
			
			fixed3 color1 = lerp(_Color.rgb, _Color2.rgb, noise1);

			fixed3 color2 = lerp(_Color3.rgb, _Color4.rgb, noise2);

			fixed3 c = lerp(color1, color2, _Noise2Factor);
			half value = c.r * 0.33 + c.g * 0.33 + c.b * 0.33;

			//apply contrast
			value = ((value - 0.5) * max(_Contrast, 0)) + 0.5;
			// apply brightness
			value = saturate(value + _Brightness);

			//remap
			o.Albedo = c.rgb;
            // smoothness comes from slider variable
            o.Metallic = 0;
            o.Smoothness = value;

			// calc normal vector

			float3 tangentPos = objPos + (IN.tangent_input * _TangentDst);
			float3 binormalPos = objPos + (IN.binormal_input * _TangentDst);

			float tangentValue = cnoise(tangentPos * _NoiseScale);
			float binormalValue = cnoise(binormalPos * _NoiseScale);

			float tangentDiff = tangentValue - pointValue;
			float binormalDiff = binormalValue - pointValue;

			/*float invTangentDst = 1 / _TangentDst;

			float tangentSlope = atan(tangentDiff * invTangentDst);
			float binormalSlope = atan(binormalDiff * invTangentDst);

			float tangentPart = tangentSlope * UNITY_INV_HALF_PI;
			float binormalPart = binormalSlope * UNITY_INV_HALF_PI;*/

			float3 normalVector = normalize(float3(tangentDiff * _NormalStrength , binormalDiff * _NormalStrength, 1));

			o.Normal = normalVector;

			//o.Albedo = (normalVector * 0.5 + 0.5).rgb;
			//o.Albedo = IN.tangent_input;

            o.Alpha = 1;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
