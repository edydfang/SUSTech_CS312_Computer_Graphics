#version 430 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
	// mix�������ݵ����������������Բ�ֵ����������ֵΪ0.0�������ص�һ�����룬����1.0�򷵻صڶ�����0.2�᷵��80%��һ���������ɫ��20%�ڶ����������ɫ
	FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
	//FragColor = texture(texture1, TexCoord) * vec4(ourColor, 1.0);
}