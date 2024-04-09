﻿using OpenTK;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Flower
    {
        public static List<Face> getFaces()
        {
            List<Face> faces = new List<Face>();

            Face f1 = new Face();
            f1.AddVertex(0.02f, -0.02f, -0.07f);
            f1.AddVertex(-0.00f, -0.02f, -0.07f);
            f1.AddVertex(-0.00f, 0.39f, 0.02f);
            f1.AddVertex(0.02f, 0.39f, 0.02f);
            faces.Add(f1);

            Face f2 = new Face();
            f2.AddVertex(-0.16f, -0.95f, 0.03f);
            f2.AddVertex(-0.16f, -0.95f, -0.16f);
            f2.AddVertex(0.19f, -0.95f, 0.03f);
            f2.AddVertex(0.01f, -0.95f, 0.14f);
            faces.Add(f2);

            Face f3 = new Face();
            f3.AddVertex(0.19f, -0.95f, 0.03f);
            f3.AddVertex(0.19f, -0.95f, -0.16f);
            f3.AddVertex(0.31f, -0.42f, -0.24f);
            f3.AddVertex(0.31f, -0.42f, 0.11f);
            faces.Add(f3);

            Face f4 = new Face();
            f4.AddVertex(0.19f, -0.95f, -0.16f);
            f4.AddVertex(0.01f, -0.95f, -0.27f);
            f4.AddVertex(0.01f, -0.42f, -0.41f);
            f4.AddVertex(0.31f, -0.42f, -0.24f);
            faces.Add(f4);

            Face f5 = new Face();
            f5.AddVertex(0.01f, -0.95f, -0.27f);
            f5.AddVertex(-0.16f, -0.95f, -0.16f);
            f5.AddVertex(-0.29f, -0.42f, -0.24f);
            f5.AddVertex(0.01f, -0.42f, -0.41f);
            faces.Add(f5);

            Face f6 = new Face();
            f6.AddVertex(-0.16f, -0.95f, -0.16f);
            f6.AddVertex(-0.16f, -0.95f, 0.03f);
            f6.AddVertex(-0.29f, -0.42f, 0.11f);
            f6.AddVertex(-0.29f, -0.42f, -0.24f);
            faces.Add(f6);

            Face f7 = new Face();
            f7.AddVertex(-0.16f, -0.95f, 0.03f);
            f7.AddVertex(0.01f, -0.95f, 0.14f);
            f7.AddVertex(0.01f, -0.42f, 0.28f);
            f7.AddVertex(-0.29f, -0.42f, 0.11f);
            faces.Add(f7);

            Face f8 = new Face();
            f8.AddVertex(0.01f, -0.42f, 0.28f);
            f8.AddVertex(0.31f, -0.42f, 0.11f);
            f8.AddVertex(0.38f, -0.42f, 0.14f);
            f8.AddVertex(0.01f, -0.42f, 0.36f);
            faces.Add(f8);

            Face f9 = new Face();
            f9.AddVertex(0.38f, -0.42f, 0.14f);
            f9.AddVertex(0.38f, -0.42f, -0.28f);
            f9.AddVertex(0.38f, -0.28f, -0.28f);
            f9.AddVertex(0.38f, -0.28f, 0.14f);
            faces.Add(f9);

            Face f10 = new Face();
            f10.AddVertex(0.38f, -0.42f, -0.28f);
            f10.AddVertex(0.01f, -0.42f, -0.49f);
            f10.AddVertex(0.01f, -0.28f, -0.49f);
            f10.AddVertex(0.38f, -0.28f, -0.28f);
            faces.Add(f10);

            Face f11 = new Face();
            f11.AddVertex(0.01f, -0.42f, -0.49f);
            f11.AddVertex(-0.36f, -0.42f, -0.28f);
            f11.AddVertex(-0.36f, -0.28f, -0.28f);
            f11.AddVertex(0.01f, -0.28f, -0.49f);
            faces.Add(f11);

            Face f12 = new Face();
            f12.AddVertex(-0.36f, -0.42f, -0.28f);
            f12.AddVertex(-0.36f, -0.42f, 0.14f);
            f12.AddVertex(-0.36f, -0.28f, 0.14f);
            f12.AddVertex(-0.36f, -0.28f, -0.28f);
            faces.Add(f12);

            Face f13 = new Face();
            f13.AddVertex(-0.36f, -0.42f, 0.14f);
            f13.AddVertex(0.01f, -0.42f, 0.36f);
            f13.AddVertex(0.01f, -0.28f, 0.36f);
            f13.AddVertex(-0.36f, -0.28f, 0.14f);
            faces.Add(f13);

            Face f14 = new Face();
            f14.AddVertex(0.31f, -0.28f, -0.24f);
            f14.AddVertex(0.31f, -0.28f, 0.11f);
            f14.AddVertex(0.38f, -0.28f, 0.14f);
            f14.AddVertex(0.38f, -0.28f, -0.28f);
            faces.Add(f14);

            Face f15 = new Face();
            f15.AddVertex(-0.16f, -0.95f, -0.16f);
            f15.AddVertex(0.01f, -0.95f, -0.27f);
            f15.AddVertex(0.19f, -0.95f, -0.16f);
            f15.AddVertex(0.19f, -0.95f, 0.03f);
            faces.Add(f15);

            Face f16 = new Face();
            f16.AddVertex(0.01f, -0.35f, 0.28f);
            f16.AddVertex(0.31f, -0.35f, 0.11f);
            f16.AddVertex(-0.29f, -0.35f, -0.24f);
            f16.AddVertex(-0.29f, -0.35f, 0.11f);
            faces.Add(f16);

            Face f17 = new Face();
            f17.AddVertex(0.31f, -0.42f, 0.11f);
            f17.AddVertex(0.31f, -0.42f, -0.24f);
            f17.AddVertex(0.38f, -0.42f, -0.28f);
            f17.AddVertex(0.38f, -0.42f, 0.14f);
            faces.Add(f17);

            Face f18 = new Face();
            f18.AddVertex(0.31f, -0.42f, -0.24f);
            f18.AddVertex(0.01f, -0.42f, -0.41f);
            f18.AddVertex(0.01f, -0.42f, -0.49f);
            f18.AddVertex(0.38f, -0.42f, -0.28f);
            faces.Add(f18);

            Face f19 = new Face();
            f19.AddVertex(-0.29f, -0.42f, 0.11f);
            f19.AddVertex(0.01f, -0.42f, 0.28f);
            f19.AddVertex(0.01f, -0.42f, 0.36f);
            f19.AddVertex(-0.36f, -0.42f, 0.14f);
            faces.Add(f19);

            Face f20 = new Face();
            f20.AddVertex(0.01f, -0.42f, -0.41f);
            f20.AddVertex(-0.29f, -0.42f, -0.24f);
            f20.AddVertex(-0.36f, -0.42f, -0.28f);
            f20.AddVertex(0.01f, -0.42f, -0.49f);
            faces.Add(f20);

            Face f21 = new Face();
            f21.AddVertex(-0.29f, -0.42f, -0.24f);
            f21.AddVertex(-0.29f, -0.42f, 0.11f);
            f21.AddVertex(-0.36f, -0.42f, 0.14f);
            f21.AddVertex(-0.36f, -0.42f, -0.28f);
            faces.Add(f21);

            Face f22 = new Face();
            f22.AddVertex(-0.29f, -0.28f, -0.24f);
            f22.AddVertex(-0.29f, -0.28f, 0.11f);
            f22.AddVertex(-0.29f, -0.35f, 0.11f);
            f22.AddVertex(-0.29f, -0.35f, -0.24f);
            faces.Add(f22);

            Face f23 = new Face();
            f23.AddVertex(0.31f, -0.28f, 0.11f);
            f23.AddVertex(0.01f, -0.28f, 0.28f);
            f23.AddVertex(0.01f, -0.28f, 0.36f);
            f23.AddVertex(0.38f, -0.28f, 0.14f);
            faces.Add(f23);

            Face f24 = new Face();
            f24.AddVertex(0.01f, -0.28f, 0.28f);
            f24.AddVertex(-0.29f, -0.28f, 0.11f);
            f24.AddVertex(-0.36f, -0.28f, 0.14f);
            f24.AddVertex(0.01f, -0.28f, 0.36f);
            faces.Add(f24);

            Face f25 = new Face();
            f25.AddVertex(-0.29f, -0.28f, 0.11f);
            f25.AddVertex(-0.29f, -0.28f, -0.24f);
            f25.AddVertex(-0.36f, -0.28f, -0.28f);
            f25.AddVertex(-0.36f, -0.28f, 0.14f);
            faces.Add(f25);

            Face f26 = new Face();
            f26.AddVertex(-0.29f, -0.28f, -0.24f);
            f26.AddVertex(0.01f, -0.28f, -0.41f);
            f26.AddVertex(0.01f, -0.28f, -0.49f);
            f26.AddVertex(-0.36f, -0.28f, -0.28f);
            faces.Add(f26);

            Face f27 = new Face();
            f27.AddVertex(0.01f, -0.28f, -0.41f);
            f27.AddVertex(0.31f, -0.28f, -0.24f);
            f27.AddVertex(0.38f, -0.28f, -0.28f);
            f27.AddVertex(0.01f, -0.28f, -0.49f);
            faces.Add(f27);

            Face f28 = new Face();
            f28.AddVertex(-0.29f, -0.28f, 0.11f);
            f28.AddVertex(0.01f, -0.28f, 0.28f);
            f28.AddVertex(0.01f, -0.35f, 0.28f);
            f28.AddVertex(-0.29f, -0.35f, 0.11f);
            faces.Add(f28);

            Face f29 = new Face();
            f29.AddVertex(0.01f, -0.28f, 0.28f);
            f29.AddVertex(0.31f, -0.28f, 0.11f);
            f29.AddVertex(0.31f, -0.35f, 0.11f);
            f29.AddVertex(0.01f, -0.35f, 0.28f);
            faces.Add(f29);

            Face f30 = new Face();
            f30.AddVertex(0.31f, -0.28f, 0.11f);
            f30.AddVertex(0.31f, -0.28f, -0.24f);
            f30.AddVertex(0.31f, -0.35f, -0.24f);
            f30.AddVertex(0.31f, -0.35f, 0.11f);
            faces.Add(f30);

            Face f31 = new Face();
            f31.AddVertex(0.31f, -0.28f, -0.24f);
            f31.AddVertex(0.01f, -0.28f, -0.41f);
            f31.AddVertex(0.01f, -0.35f, -0.41f);
            f31.AddVertex(0.31f, -0.35f, -0.24f);
            faces.Add(f31);

            Face f32 = new Face();
            f32.AddVertex(0.01f, -0.28f, -0.41f);
            f32.AddVertex(-0.29f, -0.28f, -0.24f);
            f32.AddVertex(-0.29f, -0.35f, -0.24f);
            f32.AddVertex(0.01f, -0.35f, -0.41f);
            faces.Add(f32);

            Face f33 = new Face();
            f33.AddVertex(0.01f, -0.95f, 0.14f);
            f33.AddVertex(0.19f, -0.95f, 0.03f);
            f33.AddVertex(0.31f, -0.42f, 0.11f);
            f33.AddVertex(0.01f, -0.42f, 0.28f);
            faces.Add(f33);

            Face f34 = new Face();
            f34.AddVertex(0.00f, -0.23f, -0.05f);
            f34.AddVertex(-0.15f, -0.09f, -0.12f);
            f34.AddVertex(-0.13f, -0.05f, -0.19f);
            f34.AddVertex(0.01f, -0.23f, -0.07f);
            faces.Add(f34);

            Face f35 = new Face();
            f35.AddVertex(-0.25f, 0.14f, -0.16f);
            f35.AddVertex(-0.20f, -0.03f, -0.05f);
            f35.AddVertex(-0.15f, -0.06f, -0.11f);
            faces.Add(f35);

            Face f36 = new Face();
            f36.AddVertex(-0.26f, 0.12f, -0.17f);
            f36.AddVertex(-0.25f, 0.14f, -0.16f);
            f36.AddVertex(-0.12f, -0.02f, -0.19f);
            f36.AddVertex(-0.13f, -0.05f, -0.19f);
            faces.Add(f36);

            Face f37 = new Face();
            f37.AddVertex(-0.15f, -0.09f, -0.12f);
            f37.AddVertex(-0.26f, 0.12f, -0.17f);
            f37.AddVertex(-0.13f, -0.05f, -0.19f);
            faces.Add(f37);

            Face f38 = new Face();
            f38.AddVertex(-0.12f, -0.02f, -0.19f);
            f38.AddVertex(-0.25f, 0.14f, -0.16f);
            f38.AddVertex(-0.15f, -0.06f, -0.11f);
            faces.Add(f38);

            Face f39 = new Face();
            f39.AddVertex(-0.12f, -0.02f, -0.19f);
            f39.AddVertex(0.01f, -0.23f, -0.07f);
            f39.AddVertex(-0.13f, -0.05f, -0.19f);
            faces.Add(f39);

            Face f40 = new Face();
            f40.AddVertex(-0.20f, -0.05f, -0.06f);
            f40.AddVertex(0.00f, -0.23f, -0.04f);
            f40.AddVertex(-0.20f, -0.03f, -0.05f);
            faces.Add(f40);

            Face f41 = new Face();
            f41.AddVertex(-0.20f, -0.05f, -0.06f);
            f41.AddVertex(-0.26f, 0.12f, -0.17f);
            f41.AddVertex(-0.15f, -0.09f, -0.12f);
            faces.Add(f41);

            Face f42 = new Face();
            f42.AddVertex(-0.12f, -0.02f, -0.19f);
            f42.AddVertex(-0.15f, -0.06f, -0.11f);
            f42.AddVertex(0.00f, -0.23f, -0.05f);
            f42.AddVertex(0.01f, -0.23f, -0.07f);
            faces.Add(f42);

            Face f43 = new Face();
            f43.AddVertex(0.08f, 0.35f, 0.13f);
            f43.AddVertex(0.15f, 0.35f, 0.32f);
            f43.AddVertex(0.01f, 0.30f, 0.31f);
            f43.AddVertex(0.01f, 0.35f, 0.13f);
            faces.Add(f43);

            Face f44 = new Face();
            f44.AddVertex(0.14f, 0.39f, 0.02f);
            f44.AddVertex(0.10f, 0.37f, 0.08f);
            f44.AddVertex(0.26f, 0.40f, 0.18f);
            f44.AddVertex(0.32f, 0.48f, 0.08f);
            faces.Add(f44);

            Face f45 = new Face();
            f45.AddVertex(0.42f, 0.33f, 0.25f);
            f45.AddVertex(0.42f, 0.36f, 0.26f);
            f45.AddVertex(0.29f, 0.35f, 0.33f);
            f45.AddVertex(0.29f, 0.33f, 0.32f);
            faces.Add(f45);

            Face f46 = new Face();
            f46.AddVertex(0.41f, 0.41f, 0.13f);
            f46.AddVertex(0.41f, 0.43f, 0.14f);
            f46.AddVertex(0.42f, 0.36f, 0.26f);
            f46.AddVertex(0.42f, 0.33f, 0.25f);
            faces.Add(f46);

            Face f47 = new Face();
            f47.AddVertex(0.34f, 0.52f, -0.15f);
            f47.AddVertex(0.28f, 0.52f, -0.05f);
            f47.AddVertex(0.29f, 0.49f, -0.07f);
            f47.AddVertex(0.34f, 0.50f, -0.16f);
            faces.Add(f47);

            Face f48 = new Face();
            f48.AddVertex(0.41f, 0.41f, 0.13f);
            f48.AddVertex(0.42f, 0.33f, 0.25f);
            f48.AddVertex(0.26f, 0.37f, 0.17f);
            f48.AddVertex(0.32f, 0.45f, 0.07f);
            faces.Add(f48);

            Face f49 = new Face();
            f49.AddVertex(0.08f, 0.35f, 0.13f);
            f49.AddVertex(0.01f, 0.35f, 0.13f);
            f49.AddVertex(0.01f, 0.34f, 0.31f);
            f49.AddVertex(0.15f, 0.38f, 0.33f);
            faces.Add(f49);

            Face f50 = new Face();
            f50.AddVertex(0.41f, 0.43f, 0.14f);
            f50.AddVertex(0.41f, 0.41f, 0.13f);
            f50.AddVertex(0.32f, 0.45f, 0.07f);
            f50.AddVertex(0.32f, 0.48f, 0.08f);
            faces.Add(f50);

            Face f51 = new Face();
            f51.AddVertex(0.10f, 0.37f, 0.08f);
            f51.AddVertex(0.26f, 0.37f, 0.17f);
            f51.AddVertex(0.19f, 0.36f, 0.30f);
            f51.AddVertex(0.07f, 0.35f, 0.13f);
            faces.Add(f51);

            Face f52 = new Face();
            f52.AddVertex(0.41f, 0.43f, 0.14f);
            f52.AddVertex(0.32f, 0.48f, 0.08f);
            f52.AddVertex(0.26f, 0.40f, 0.18f);
            f52.AddVertex(0.42f, 0.36f, 0.26f);
            faces.Add(f52);

            Face f53 = new Face();
            f53.AddVertex(0.18f, 0.39f, 0.31f);
            f53.AddVertex(0.07f, 0.35f, 0.13f);
            f53.AddVertex(0.19f, 0.36f, 0.30f);
            faces.Add(f53);

            Face f54 = new Face();
            f54.AddVertex(0.32f, 0.45f, 0.07f);
            f54.AddVertex(0.14f, 0.39f, 0.02f);
            f54.AddVertex(0.32f, 0.48f, 0.08f);
            faces.Add(f54);

            Face f55 = new Face();
            f55.AddVertex(0.42f, 0.33f, 0.25f);
            f55.AddVertex(0.29f, 0.33f, 0.32f);
            f55.AddVertex(0.19f, 0.36f, 0.30f);
            f55.AddVertex(0.26f, 0.37f, 0.17f);
            faces.Add(f55);

            Face f56 = new Face();
            f56.AddVertex(0.29f, 0.35f, 0.33f);
            f56.AddVertex(0.42f, 0.36f, 0.26f);
            f56.AddVertex(0.26f, 0.40f, 0.18f);
            f56.AddVertex(0.18f, 0.39f, 0.31f);
            faces.Add(f56);

            Face f57 = new Face();
            f57.AddVertex(-0.42f, 0.30f, 0.16f);
            f57.AddVertex(-0.39f, 0.38f, 0.04f);
            f57.AddVertex(-0.29f, 0.43f, 0.00f);
            f57.AddVertex(-0.25f, 0.35f, 0.12f);
            faces.Add(f57);

            Face f58 = new Face();
            f58.AddVertex(-0.09f, 0.39f, -0.01f);
            f58.AddVertex(-0.04f, 0.41f, -0.04f);
            f58.AddVertex(-0.15f, 0.50f, -0.16f);
            f58.AddVertex(-0.26f, 0.51f, -0.08f);
            faces.Add(f58);

            Face f59 = new Face();
            f59.AddVertex(-0.42f, 0.30f, 0.16f);
            f59.AddVertex(-0.42f, 0.33f, 0.17f);
            f59.AddVertex(-0.39f, 0.40f, 0.05f);
            f59.AddVertex(-0.39f, 0.38f, 0.04f);
            faces.Add(f59);

            Face f60 = new Face();
            f60.AddVertex(-0.31f, 0.31f, 0.26f);
            f60.AddVertex(-0.31f, 0.33f, 0.26f);
            f60.AddVertex(-0.42f, 0.33f, 0.17f);
            f60.AddVertex(-0.42f, 0.30f, 0.16f);
            faces.Add(f60);

            Face f61 = new Face();
            f61.AddVertex(0.18f, 0.39f, 0.31f);
            f61.AddVertex(0.26f, 0.40f, 0.18f);
            f61.AddVertex(0.10f, 0.37f, 0.08f);
            f61.AddVertex(0.07f, 0.35f, 0.13f);
            faces.Add(f61);

            Face f62 = new Face();
            f62.AddVertex(0.02f, 0.43f, -0.08f);
            f62.AddVertex(0.07f, 0.54f, -0.23f);
            f62.AddVertex(0.18f, 0.48f, -0.16f);
            f62.AddVertex(0.07f, 0.41f, -0.04f);
            faces.Add(f62);

            Face f63 = new Face();
            f63.AddVertex(-0.39f, 0.40f, 0.05f);
            f63.AddVertex(-0.42f, 0.33f, 0.17f);
            f63.AddVertex(-0.25f, 0.39f, 0.13f);
            f63.AddVertex(-0.29f, 0.46f, 0.01f);
            faces.Add(f63);

            Face f64 = new Face();
            f64.AddVertex(-0.31f, 0.33f, 0.26f);
            f64.AddVertex(-0.31f, 0.31f, 0.26f);
            f64.AddVertex(-0.21f, 0.34f, 0.25f);
            f64.AddVertex(-0.21f, 0.38f, 0.26f);
            faces.Add(f64);

            Face f65 = new Face();
            f65.AddVertex(-0.31f, 0.31f, 0.26f);
            f65.AddVertex(-0.42f, 0.30f, 0.16f);
            f65.AddVertex(-0.25f, 0.35f, 0.12f);
            f65.AddVertex(-0.21f, 0.34f, 0.25f);
            faces.Add(f65);

            Face f66 = new Face();
            f66.AddVertex(-0.29f, 0.46f, 0.01f);
            f66.AddVertex(-0.25f, 0.39f, 0.13f);
            f66.AddVertex(-0.08f, 0.37f, 0.06f);
            f66.AddVertex(-0.10f, 0.39f, 0.00f);
            faces.Add(f66);

            Face f67 = new Face();
            f67.AddVertex(-0.29f, 0.46f, 0.01f);
            f67.AddVertex(-0.10f, 0.39f, 0.00f);
            f67.AddVertex(-0.29f, 0.43f, 0.00f);
            faces.Add(f67);

            Face f68 = new Face();
            f68.AddVertex(-0.21f, 0.34f, 0.25f);
            f68.AddVertex(-0.06f, 0.35f, 0.12f);
            f68.AddVertex(-0.21f, 0.38f, 0.26f);
            faces.Add(f68);

            Face f69 = new Face();
            f69.AddVertex(-0.06f, 0.35f, 0.12f);
            f69.AddVertex(-0.21f, 0.34f, 0.25f);
            f69.AddVertex(-0.25f, 0.35f, 0.12f);
            f69.AddVertex(-0.08f, 0.37f, 0.06f);
            faces.Add(f69);

            Face f70 = new Face();
            f70.AddVertex(-0.31f, 0.33f, 0.26f);
            f70.AddVertex(-0.21f, 0.38f, 0.26f);
            f70.AddVertex(-0.25f, 0.39f, 0.13f);
            f70.AddVertex(-0.42f, 0.33f, 0.17f);
            faces.Add(f70);

            Face f71 = new Face();
            f71.AddVertex(0.02f, 0.22f, 0.47f);
            f71.AddVertex(-0.09f, 0.27f, 0.41f);
            f71.AddVertex(-0.12f, 0.32f, 0.31f);
            f71.AddVertex(0.01f, 0.30f, 0.31f);
            faces.Add(f71);

            Face f72 = new Face();
            f72.AddVertex(-0.06f, 0.35f, 0.12f);
            f72.AddVertex(-0.08f, 0.37f, 0.06f);
            f72.AddVertex(-0.25f, 0.39f, 0.13f);
            f72.AddVertex(-0.21f, 0.38f, 0.26f);
            faces.Add(f72);

            Face f73 = new Face();
            f73.AddVertex(0.29f, 0.35f, 0.33f);
            f73.AddVertex(0.18f, 0.39f, 0.31f);
            f73.AddVertex(0.19f, 0.36f, 0.30f);
            f73.AddVertex(0.29f, 0.33f, 0.32f);
            faces.Add(f73);

            Face f74 = new Face();
            f74.AddVertex(-0.10f, 0.29f, 0.41f);
            f74.AddVertex(-0.12f, 0.36f, 0.32f);
            f74.AddVertex(-0.12f, 0.32f, 0.31f);
            f74.AddVertex(-0.09f, 0.27f, 0.41f);
            faces.Add(f74);

            Face f75 = new Face();
            f75.AddVertex(0.13f, 0.29f, 0.41f);
            f75.AddVertex(0.13f, 0.31f, 0.41f);
            f75.AddVertex(0.02f, 0.25f, 0.48f);
            f75.AddVertex(0.02f, 0.22f, 0.47f);
            faces.Add(f75);

            Face f76 = new Face();
            f76.AddVertex(0.01f, 0.35f, 0.13f);
            f76.AddVertex(0.01f, 0.30f, 0.31f);
            f76.AddVertex(-0.12f, 0.32f, 0.31f);
            f76.AddVertex(-0.04f, 0.34f, 0.13f);
            faces.Add(f76);

            Face f77 = new Face();
            f77.AddVertex(-0.10f, 0.29f, 0.41f);
            f77.AddVertex(0.02f, 0.25f, 0.48f);
            f77.AddVertex(0.01f, 0.34f, 0.31f);
            f77.AddVertex(-0.12f, 0.36f, 0.32f);
            faces.Add(f77);

            Face f78 = new Face();
            f78.AddVertex(0.02f, 0.22f, 0.47f);
            f78.AddVertex(0.02f, 0.25f, 0.48f);
            f78.AddVertex(-0.10f, 0.29f, 0.41f);
            f78.AddVertex(-0.09f, 0.27f, 0.41f);
            faces.Add(f78);

            Face f79 = new Face();
            f79.AddVertex(0.13f, 0.29f, 0.41f);
            f79.AddVertex(0.02f, 0.22f, 0.47f);
            f79.AddVertex(0.01f, 0.30f, 0.31f);
            f79.AddVertex(0.15f, 0.35f, 0.32f);
            faces.Add(f79);

            Face f80 = new Face();
            f80.AddVertex(-0.12f, 0.36f, 0.32f);
            f80.AddVertex(0.01f, 0.34f, 0.31f);
            f80.AddVertex(0.01f, 0.35f, 0.13f);
            f80.AddVertex(-0.04f, 0.34f, 0.13f);
            faces.Add(f80);

            Face f81 = new Face();
            f81.AddVertex(-0.12f, 0.36f, 0.32f);
            f81.AddVertex(-0.04f, 0.34f, 0.13f);
            f81.AddVertex(-0.12f, 0.32f, 0.31f);
            faces.Add(f81);

            Face f82 = new Face();
            f82.AddVertex(0.15f, 0.35f, 0.32f);
            f82.AddVertex(0.08f, 0.35f, 0.13f);
            f82.AddVertex(0.15f, 0.38f, 0.33f);
            faces.Add(f82);

            Face f83 = new Face();
            f83.AddVertex(0.13f, 0.31f, 0.41f);
            f83.AddVertex(0.15f, 0.38f, 0.33f);
            f83.AddVertex(0.01f, 0.34f, 0.31f);
            f83.AddVertex(0.02f, 0.25f, 0.48f);
            faces.Add(f83);

            Face f84 = new Face();
            f84.AddVertex(0.00f, 0.48f, 0.06f);
            f84.AddVertex(0.14f, 0.41f, -0.00f);
            f84.AddVertex(0.01f, 0.43f, -0.09f);
            faces.Add(f84);

            Face f85 = new Face();
            f85.AddVertex(0.00f, 0.48f, 0.06f);
            f85.AddVertex(0.01f, 0.43f, -0.09f);
            f85.AddVertex(-0.11f, 0.39f, -0.01f);
            faces.Add(f85);

            Face f86 = new Face();
            f86.AddVertex(0.00f, 0.48f, 0.06f);
            f86.AddVertex(-0.11f, 0.39f, -0.01f);
            f86.AddVertex(-0.06f, 0.34f, 0.13f);
            faces.Add(f86);

            Face f87 = new Face();
            f87.AddVertex(0.00f, 0.48f, 0.06f);
            f87.AddVertex(-0.06f, 0.34f, 0.13f);
            f87.AddVertex(0.09f, 0.35f, 0.13f);
            faces.Add(f87);

            Face f88 = new Face();
            f88.AddVertex(0.00f, 0.48f, 0.06f);
            f88.AddVertex(0.09f, 0.35f, 0.13f);
            f88.AddVertex(0.14f, 0.41f, -0.00f);
            faces.Add(f88);

            Face f89 = new Face();
            f89.AddVertex(-0.08f, 0.37f, 0.06f);
            f89.AddVertex(-0.25f, 0.35f, 0.12f);
            f89.AddVertex(-0.29f, 0.43f, 0.00f);
            f89.AddVertex(-0.10f, 0.39f, 0.00f);
            faces.Add(f89);

            Face f90 = new Face();
            f90.AddVertex(0.02f, 0.43f, -0.08f);
            f90.AddVertex(0.07f, 0.41f, -0.04f);
            f90.AddVertex(0.18f, 0.52f, -0.15f);
            f90.AddVertex(0.07f, 0.57f, -0.22f);
            faces.Add(f90);

            Face f91 = new Face();
            f91.AddVertex(-0.25f, 0.50f, -0.33f);
            f91.AddVertex(-0.25f, 0.53f, -0.31f);
            f91.AddVertex(-0.11f, 0.56f, -0.31f);
            f91.AddVertex(-0.11f, 0.54f, -0.32f);
            faces.Add(f91);

            Face f92 = new Face();
            f92.AddVertex(-0.30f, 0.48f, -0.19f);
            f92.AddVertex(-0.30f, 0.50f, -0.18f);
            f92.AddVertex(-0.25f, 0.53f, -0.31f);
            f92.AddVertex(-0.25f, 0.50f, -0.33f);
            faces.Add(f92);

            Face f93 = new Face();
            f93.AddVertex(-0.39f, 0.40f, 0.05f);
            f93.AddVertex(-0.29f, 0.46f, 0.01f);
            f93.AddVertex(-0.29f, 0.43f, 0.00f);
            f93.AddVertex(-0.39f, 0.38f, 0.04f);
            faces.Add(f93);

            Face f94 = new Face();
            f94.AddVertex(-0.30f, 0.48f, -0.19f);
            f94.AddVertex(-0.25f, 0.50f, -0.33f);
            f94.AddVertex(-0.15f, 0.47f, -0.18f);
            f94.AddVertex(-0.26f, 0.47f, -0.09f);
            faces.Add(f94);

            Face f95 = new Face();
            f95.AddVertex(-0.11f, 0.56f, -0.31f);
            f95.AddVertex(-0.25f, 0.53f, -0.31f);
            f95.AddVertex(-0.15f, 0.50f, -0.16f);
            f95.AddVertex(-0.03f, 0.57f, -0.22f);
            faces.Add(f95);

            Face f96 = new Face();
            f96.AddVertex(-0.30f, 0.50f, -0.18f);
            f96.AddVertex(-0.30f, 0.48f, -0.19f);
            f96.AddVertex(-0.26f, 0.47f, -0.09f);
            f96.AddVertex(-0.26f, 0.51f, -0.08f);
            faces.Add(f96);

            Face f97 = new Face();
            f97.AddVertex(-0.04f, 0.41f, -0.04f);
            f97.AddVertex(-0.15f, 0.47f, -0.18f);
            f97.AddVertex(-0.03f, 0.54f, -0.24f);
            f97.AddVertex(0.00f, 0.43f, -0.08f);
            faces.Add(f97);

            Face f98 = new Face();
            f98.AddVertex(-0.03f, 0.57f, -0.22f);
            f98.AddVertex(-0.15f, 0.50f, -0.16f);
            f98.AddVertex(-0.04f, 0.41f, -0.04f);
            f98.AddVertex(0.00f, 0.43f, -0.08f);
            faces.Add(f98);

            Face f99 = new Face();
            f99.AddVertex(-0.03f, 0.57f, -0.22f);
            f99.AddVertex(0.00f, 0.43f, -0.08f);
            f99.AddVertex(-0.03f, 0.54f, -0.24f);
            faces.Add(f99);

            Face f100 = new Face();
            f100.AddVertex(-0.26f, 0.47f, -0.09f);
            f100.AddVertex(-0.09f, 0.39f, -0.01f);
            f100.AddVertex(-0.26f, 0.51f, -0.08f);
            faces.Add(f100);

            Face f101 = new Face();
            f101.AddVertex(-0.25f, 0.50f, -0.33f);
            f101.AddVertex(-0.11f, 0.54f, -0.32f);
            f101.AddVertex(-0.03f, 0.54f, -0.24f);
            f101.AddVertex(-0.15f, 0.47f, -0.18f);
            faces.Add(f101);

            Face f102 = new Face();
            f102.AddVertex(-0.30f, 0.50f, -0.18f);
            f102.AddVertex(-0.26f, 0.51f, -0.08f);
            f102.AddVertex(-0.15f, 0.50f, -0.16f);
            f102.AddVertex(-0.25f, 0.53f, -0.31f);
            faces.Add(f102);

            Face f103 = new Face();
            f103.AddVertex(0.30f, 0.52f, -0.30f);
            f103.AddVertex(0.34f, 0.50f, -0.16f);
            f103.AddVertex(0.29f, 0.49f, -0.07f);
            f103.AddVertex(0.18f, 0.48f, -0.16f);
            faces.Add(f103);

            Face f104 = new Face();
            f104.AddVertex(0.15f, 0.56f, -0.30f);
            f104.AddVertex(0.07f, 0.57f, -0.22f);
            f104.AddVertex(0.18f, 0.52f, -0.15f);
            f104.AddVertex(0.30f, 0.54f, -0.29f);
            faces.Add(f104);

            Face f105 = new Face();
            f105.AddVertex(0.30f, 0.52f, -0.30f);
            f105.AddVertex(0.30f, 0.54f, -0.29f);
            f105.AddVertex(0.34f, 0.52f, -0.15f);
            f105.AddVertex(0.34f, 0.50f, -0.16f);
            faces.Add(f105);

            Face f106 = new Face();
            f106.AddVertex(0.16f, 0.54f, -0.31f);
            f106.AddVertex(0.15f, 0.56f, -0.30f);
            f106.AddVertex(0.30f, 0.54f, -0.29f);
            f106.AddVertex(0.30f, 0.52f, -0.30f);
            faces.Add(f106);

            Face f107 = new Face();
            f107.AddVertex(-0.11f, 0.56f, -0.31f);
            f107.AddVertex(-0.03f, 0.57f, -0.22f);
            f107.AddVertex(-0.03f, 0.54f, -0.24f);
            f107.AddVertex(-0.11f, 0.54f, -0.32f);
            faces.Add(f107);

            Face f108 = new Face();
            f108.AddVertex(0.16f, 0.54f, -0.31f);
            f108.AddVertex(0.30f, 0.52f, -0.30f);
            f108.AddVertex(0.18f, 0.48f, -0.16f);
            f108.AddVertex(0.07f, 0.54f, -0.23f);
            faces.Add(f108);

            Face f109 = new Face();
            f109.AddVertex(0.34f, 0.52f, -0.15f);
            f109.AddVertex(0.30f, 0.54f, -0.29f);
            f109.AddVertex(0.18f, 0.52f, -0.15f);
            f109.AddVertex(0.28f, 0.52f, -0.05f);
            faces.Add(f109);

            Face f110 = new Face();
            f110.AddVertex(0.15f, 0.56f, -0.30f);
            f110.AddVertex(0.16f, 0.54f, -0.31f);
            f110.AddVertex(0.07f, 0.54f, -0.23f);
            f110.AddVertex(0.07f, 0.57f, -0.22f);
            faces.Add(f110);

            Face f111 = new Face();
            f111.AddVertex(0.14f, 0.39f, 0.02f);
            f111.AddVertex(0.32f, 0.45f, 0.07f);
            f111.AddVertex(0.26f, 0.37f, 0.17f);
            f111.AddVertex(0.10f, 0.37f, 0.08f);
            faces.Add(f111);

            Face f112 = new Face();
            f112.AddVertex(-0.09f, 0.39f, -0.01f);
            f112.AddVertex(-0.26f, 0.47f, -0.09f);
            f112.AddVertex(-0.15f, 0.47f, -0.18f);
            f112.AddVertex(-0.04f, 0.41f, -0.04f);
            faces.Add(f112);

            Face f113 = new Face();
            f113.AddVertex(0.28f, 0.52f, -0.05f);
            f113.AddVertex(0.12f, 0.40f, -0.00f);
            f113.AddVertex(0.29f, 0.49f, -0.07f);
            faces.Add(f113);

            Face f114 = new Face();
            f114.AddVertex(0.07f, 0.54f, -0.23f);
            f114.AddVertex(0.02f, 0.43f, -0.08f);
            f114.AddVertex(0.07f, 0.57f, -0.22f);
            faces.Add(f114);

            Face f115 = new Face();
            f115.AddVertex(0.07f, 0.41f, -0.04f);
            f115.AddVertex(0.18f, 0.48f, -0.16f);
            f115.AddVertex(0.29f, 0.49f, -0.07f);
            f115.AddVertex(0.12f, 0.40f, -0.00f);
            faces.Add(f115);

            Face f116 = new Face();
            f116.AddVertex(0.28f, 0.52f, -0.05f);
            f116.AddVertex(0.18f, 0.52f, -0.15f);
            f116.AddVertex(0.07f, 0.41f, -0.04f);
            f116.AddVertex(0.12f, 0.40f, -0.00f);
            faces.Add(f116);

            Face f117 = new Face();
            f117.AddVertex(0.02f, -0.41f, -0.05f);
            f117.AddVertex(0.02f, -0.41f, -0.08f);
            f117.AddVertex(0.02f, -0.02f, -0.07f);
            f117.AddVertex(0.02f, -0.02f, -0.05f);
            faces.Add(f117);

            Face f118 = new Face();
            f118.AddVertex(-0.00f, -0.41f, -0.08f);
            f118.AddVertex(-0.00f, -0.41f, -0.05f);
            f118.AddVertex(-0.00f, -0.02f, -0.05f);
            f118.AddVertex(-0.00f, -0.02f, -0.07f);
            faces.Add(f118);

            Face f119 = new Face();
            f119.AddVertex(-0.00f, -0.41f, -0.05f);
            f119.AddVertex(0.01f, -0.41f, -0.04f);
            f119.AddVertex(0.01f, -0.02f, -0.04f);
            f119.AddVertex(-0.00f, -0.02f, -0.05f);
            faces.Add(f119);

            Face f120 = new Face();
            f120.AddVertex(0.01f, -0.41f, -0.04f);
            f120.AddVertex(0.02f, -0.41f, -0.05f);
            f120.AddVertex(0.02f, -0.02f, -0.05f);
            f120.AddVertex(0.01f, -0.02f, -0.04f);
            faces.Add(f120);

            Face f121 = new Face();
            f121.AddVertex(0.02f, -0.02f, -0.05f);
            f121.AddVertex(0.02f, -0.02f, -0.07f);
            f121.AddVertex(0.02f, 0.39f, 0.02f);
            f121.AddVertex(0.02f, 0.39f, 0.04f);
            faces.Add(f121);

            Face f122 = new Face();
            f122.AddVertex(0.02f, -0.41f, -0.08f);
            f122.AddVertex(-0.00f, -0.41f, -0.08f);
            f122.AddVertex(-0.00f, -0.02f, -0.07f);
            f122.AddVertex(0.02f, -0.02f, -0.07f);
            faces.Add(f122);

            Face f123 = new Face();
            f123.AddVertex(-0.00f, -0.02f, -0.07f);
            f123.AddVertex(-0.00f, -0.02f, -0.05f);
            f123.AddVertex(-0.00f, 0.39f, 0.04f);
            f123.AddVertex(-0.00f, 0.39f, 0.02f);
            faces.Add(f123);

            Face f124 = new Face();
            f124.AddVertex(-0.00f, -0.02f, -0.05f);
            f124.AddVertex(0.01f, -0.02f, -0.04f);
            f124.AddVertex(0.01f, 0.39f, 0.05f);
            f124.AddVertex(-0.00f, 0.39f, 0.04f);
            faces.Add(f124);

            Face f125 = new Face();
            f125.AddVertex(0.01f, -0.02f, -0.04f);
            f125.AddVertex(0.02f, -0.02f, -0.05f);
            f125.AddVertex(0.02f, 0.39f, 0.04f);
            f125.AddVertex(0.01f, 0.39f, 0.05f);
            faces.Add(f125);

            Face f126 = new Face();
            f126.AddVertex(0.01f, -0.42f, 0.36f);
            f126.AddVertex(0.38f, -0.42f, 0.14f);
            f126.AddVertex(0.38f, -0.28f, 0.14f);
            f126.AddVertex(0.01f, -0.28f, 0.36f);
            faces.Add(f126);

            Face f127 = new Face();
            f127.AddVertex(-0.20f, -0.05f, -0.06f);
            f127.AddVertex(-0.20f, -0.03f, -0.05f);
            f127.AddVertex(-0.25f, 0.14f, -0.16f);
            f127.AddVertex(-0.26f, 0.12f, -0.17f);
            faces.Add(f127);

            Face f128 = new Face();
            f128.AddVertex(0.00f, -0.23f, -0.04f);
            f128.AddVertex(-0.20f, -0.05f, -0.06f);
            f128.AddVertex(-0.15f, -0.09f, -0.12f);
            f128.AddVertex(0.00f, -0.23f, -0.05f);
            faces.Add(f128);

            Face f129 = new Face();
            f129.AddVertex(0.00f, -0.23f, -0.04f);
            f129.AddVertex(0.00f, -0.23f, -0.05f);
            f129.AddVertex(-0.15f, -0.06f, -0.11f);
            f129.AddVertex(-0.20f, -0.03f, -0.05f);
            faces.Add(f129);

            Face f130 = new Face();
            f130.AddVertex(0.13f, 0.31f, 0.41f);
            f130.AddVertex(0.13f, 0.29f, 0.41f);
            f130.AddVertex(0.15f, 0.35f, 0.32f);
            f130.AddVertex(0.15f, 0.38f, 0.33f);
            faces.Add(f130);

            Face f131 = new Face();
            f131.AddVertex(-0.06f, 0.34f, 0.13f);
            f131.AddVertex(-0.11f, 0.39f, -0.01f);
            f131.AddVertex(0.01f, 0.43f, -0.09f);
            f131.AddVertex(0.14f, 0.41f, -0.00f);
            f131.AddVertex(0.09f, 0.35f, 0.13f);
            faces.Add(f131);

            Face f132 = new Face();
            f132.AddVertex(0.31f, -0.35f, 0.11f);
            f132.AddVertex(0.31f, -0.35f, -0.24f);
            f132.AddVertex(0.01f, -0.35f, -0.41f);
            f132.AddVertex(-0.29f, -0.35f, -0.24f);
            faces.Add(f132);

            foreach (Face f in faces)
            {
                List<Vector3> vertices = f.GetVertices();
                for (int i = 0; i < vertices.Count; i++)
                {
                    Vector3 vertex = vertices[i];
                    vertex.X *= 10;
                    vertex.Y *= 10;
                    vertex.Z *= 10;
                    vertices[i] = vertex;
                }
            }

            return faces;
        }
    }
}
