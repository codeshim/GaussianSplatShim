using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GaussianSplatting.Runtime
{
    class GaussianSplatRenderSystem
    {
        public static GaussianSplatRenderSystem instance => ms_Instance ??= new GaussianSplatRenderSystem();
        static GaussianSplatRenderSystem ms_Instance;

        public void RegisterSplat(GaussianSplatRenderer r)
        {

        }
    }

    public class GaussianSplatRenderer : MonoBehaviour
    {
        public GaussianSplatAsset m_Asset;

        public Shader m_ShaderSplats;

        int m_SplatCount; // initially same as asset splat count, but editing can change this

        internal Material m_MatSplats;

        public GaussianSplatAsset asset => m_Asset;

        void CreateResourcesForAsset()
        {

        }

        public void OnEnable()
        {
            Debug.Log("OnEnable");

            m_MatSplats = new Material(m_ShaderSplats) { name = "GaussianSplats" };

            GaussianSplatRenderSystem.instance.RegisterSplat(this);

            CreateResourcesForAsset();
        }
    }
}
