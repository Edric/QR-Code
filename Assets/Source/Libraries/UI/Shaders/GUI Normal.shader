Shader "GUI/Normal" {
Properties {
	//_Color ("Main Color", Color) = (1,1,1,1)
	_MainTex ("Main Texture", 2D) = "" {}
}

Category {
	Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
	Blend SrcAlpha OneMinusSrcAlpha
	AlphaTest Off
	
	Cull Off Lighting Off ZWrite On Fog { Mode Off }
	BindChannels {
		Bind "Color", color
		Bind "Vertex", vertex
		Bind "TexCoord", texcoord
	}
	
	SubShader {
		Pass {
			SetTexture [_MainTex] {
				//constantColor [_Color]
				combine texture * Primary//constant
			}
		}
	}
	
}
}
