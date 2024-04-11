using OpenTK;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Television
    {
        public static List<Face> getFaces()
        {
            List<Face> faces = new List<Face>();

            Face f1 = new Face();
            f1.AddVertex(-0.45000f, 0.17000f, 0.01000f);
            f1.AddVertex(-0.45000f, 0.12128f, 0.01000f);
            f1.AddVertex(-0.45000f, 0.12128f, 0.01482f);
            f1.AddVertex(-0.45000f, 0.17000f, 0.01482f);
            faces.Add(f1);

            Face f2 = new Face();
            f2.AddVertex(-0.45000f, 0.64871f, -0.01000f);
            f2.AddVertex(-0.44714f, 0.65935f, -0.01000f);
            f2.AddVertex(-0.43935f, 0.66714f, -0.01000f);
            f2.AddVertex(-0.42871f, 0.67000f, -0.01000f);
            f2.AddVertex(0.42871f, 0.67000f, -0.01000f);
            f2.AddVertex(0.43935f, 0.66714f, -0.01000f);
            f2.AddVertex(0.44714f, 0.65935f, -0.01000f);
            f2.AddVertex(0.45000f, 0.64871f, -0.01000f);
            f2.AddVertex(0.45000f, 0.17000f, -0.01000f);
            f2.AddVertex(-0.45000f, 0.17000f, -0.01000f);
            faces.Add(f2);

            Face f3 = new Face();
            f3.AddVertex(0.45000f, 0.64871f, -0.01000f);
            f3.AddVertex(0.45000f, 0.64871f, 0.01000f);
            f3.AddVertex(0.45000f, 0.17000f, 0.01000f);
            f3.AddVertex(0.45000f, 0.17000f, -0.01000f);
            faces.Add(f3);

            Face f4 = new Face();
            f4.AddVertex(-0.43460f, 0.65530f, 0.01000f);
            f4.AddVertex(-0.45000f, 0.64871f, 0.01000f);
            f4.AddVertex(-0.45000f, 0.17000f, 0.01000f);
            f4.AddVertex(-0.40859f, 0.20952f, 0.01000f);
            f4.AddVertex(-0.40859f, 0.63047f, 0.01000f);
            faces.Add(f4);

            Face f5 = new Face();
            f5.AddVertex(-0.42871f, 0.10000f, 0.01000f);
            f5.AddVertex(0.42871f, 0.10000f, 0.01000f);
            f5.AddVertex(0.42871f, 0.10000f, 0.01482f);
            f5.AddVertex(-0.42871f, 0.10000f, 0.01482f);
            faces.Add(f5);

            Face f6 = new Face();
            f6.AddVertex(0.43460f, 0.65530f, 0.01000f);
            f6.AddVertex(0.42871f, 0.67000f, 0.01000f);
            f6.AddVertex(-0.42871f, 0.67000f, 0.01000f);
            f6.AddVertex(-0.43460f, 0.65530f, 0.01000f);
            f6.AddVertex(-0.40859f, 0.63047f, 0.01000f);
            f6.AddVertex(0.40859f, 0.63047f, 0.01000f);
            faces.Add(f6);

            Face f7 = new Face();
            f7.AddVertex(-0.45000f, 0.17000f, -0.01000f);
            f7.AddVertex(0.45000f, 0.17000f, -0.01000f);
            f7.AddVertex(0.45000f, 0.12128f, -0.01000f);
            f7.AddVertex(0.44714f, 0.11064f, -0.01000f);
            f7.AddVertex(0.43935f, 0.10285f, -0.01000f);
            f7.AddVertex(0.42871f, 0.10000f, -0.01000f);
            f7.AddVertex(-0.42871f, 0.10000f, -0.01000f);
            f7.AddVertex(-0.43935f, 0.10285f, -0.01000f);
            f7.AddVertex(-0.44714f, 0.11064f, -0.01000f);
            f7.AddVertex(-0.45000f, 0.12128f, -0.01000f);
            faces.Add(f7);

            Face f8 = new Face();
            f8.AddVertex(0.45000f, 0.17000f, 0.01000f);
            f8.AddVertex(0.45000f, 0.64871f, 0.01000f);
            f8.AddVertex(0.43460f, 0.65530f, 0.01000f);
            f8.AddVertex(0.40859f, 0.63047f, 0.01000f);
            f8.AddVertex(0.40859f, 0.20952f, 0.01000f);
            faces.Add(f8);

            Face f9 = new Face();
            f9.AddVertex(0.45000f, 0.12128f, 0.01000f);
            f9.AddVertex(0.45000f, 0.17000f, 0.01000f);
            f9.AddVertex(0.45000f, 0.17000f, 0.01482f);
            f9.AddVertex(0.45000f, 0.12128f, 0.01482f);
            faces.Add(f9);

            Face f10 = new Face();
            f10.AddVertex(0.42871f, 0.67000f, 0.01000f);
            f10.AddVertex(0.42871f, 0.67000f, -0.01000f);
            f10.AddVertex(-0.42871f, 0.67000f, -0.01000f);
            f10.AddVertex(-0.42871f, 0.67000f, 0.01000f);
            faces.Add(f10);

            Face f11 = new Face();
            f11.AddVertex(-0.40859f, 0.20952f, 0.01000f);
            f11.AddVertex(0.40859f, 0.20952f, 0.01000f);
            f11.AddVertex(0.40859f, 0.20952f, 0.00609f);
            f11.AddVertex(-0.40859f, 0.20952f, 0.00609f);
            faces.Add(f11);

            Face f12 = new Face();
            f12.AddVertex(0.45000f, 0.17000f, 0.01482f);
            f12.AddVertex(-0.45000f, 0.17000f, 0.01482f);
            f12.AddVertex(-0.45000f, 0.12128f, 0.01482f);
            f12.AddVertex(-0.44714f, 0.11064f, 0.01482f);
            f12.AddVertex(-0.43935f, 0.10285f, 0.01482f);
            f12.AddVertex(-0.42871f, 0.10000f, 0.01482f);
            f12.AddVertex(0.42871f, 0.10000f, 0.01482f);
            f12.AddVertex(0.43935f, 0.10285f, 0.01482f);
            f12.AddVertex(0.44714f, 0.11064f, 0.01482f);
            f12.AddVertex(0.45000f, 0.12128f, 0.01482f);
            faces.Add(f12);

            Face f13 = new Face();
            f13.AddVertex(-0.45000f, 0.64871f, 0.01000f);
            f13.AddVertex(-0.45000f, 0.64871f, -0.01000f);
            f13.AddVertex(-0.45000f, 0.17000f, -0.01000f);
            f13.AddVertex(-0.45000f, 0.17000f, 0.01000f);
            faces.Add(f13);

            Face f14 = new Face();
            f14.AddVertex(-0.45000f, 0.17000f, 0.01000f);
            f14.AddVertex(0.45000f, 0.17000f, 0.01000f);
            f14.AddVertex(0.40859f, 0.20952f, 0.01000f);
            f14.AddVertex(-0.40859f, 0.20952f, 0.01000f);
            faces.Add(f14);

            Face f15 = new Face();
            f15.AddVertex(0.40859f, 0.63047f, 0.00609f);
            f15.AddVertex(-0.40859f, 0.63047f, 0.00609f);
            f15.AddVertex(-0.40859f, 0.20952f, 0.00609f);
            f15.AddVertex(0.40859f, 0.20952f, 0.00609f);
            faces.Add(f15);

            Face f16 = new Face();
            f16.AddVertex(0.40859f, 0.63047f, 0.01000f);
            f16.AddVertex(-0.40859f, 0.63047f, 0.01000f);
            f16.AddVertex(-0.40859f, 0.63047f, 0.00609f);
            f16.AddVertex(0.40859f, 0.63047f, 0.00609f);
            faces.Add(f16);

            Face f17 = new Face();
            f17.AddVertex(0.40859f, 0.20952f, 0.01000f);
            f17.AddVertex(0.40859f, 0.63047f, 0.01000f);
            f17.AddVertex(0.40859f, 0.63047f, 0.00609f);
            f17.AddVertex(0.40859f, 0.20952f, 0.00609f);
            faces.Add(f17);

            Face f18 = new Face();
            f18.AddVertex(-0.40859f, 0.63047f, 0.01000f);
            f18.AddVertex(-0.40859f, 0.20952f, 0.01000f);
            f18.AddVertex(-0.40859f, 0.20952f, 0.00609f);
            f18.AddVertex(-0.40859f, 0.63047f, 0.00609f);
            faces.Add(f18);

            Face f19 = new Face();
            f19.AddVertex(0.45000f, 0.17000f, -0.01000f);
            f19.AddVertex(0.45000f, 0.17000f, 0.01000f);
            f19.AddVertex(0.45000f, 0.12128f, 0.01000f);
            f19.AddVertex(0.45000f, 0.12128f, -0.01000f);
            faces.Add(f19);

            Face f20 = new Face();
            f20.AddVertex(-0.45000f, 0.17000f, 0.01000f);
            f20.AddVertex(-0.45000f, 0.17000f, -0.01000f);
            f20.AddVertex(-0.45000f, 0.12128f, -0.01000f);
            f20.AddVertex(-0.45000f, 0.12128f, 0.01000f);
            faces.Add(f20);

            Face f21 = new Face();
            f21.AddVertex(0.45000f, 0.17000f, 0.01000f);
            f21.AddVertex(-0.45000f, 0.17000f, 0.01000f);
            f21.AddVertex(-0.45000f, 0.17000f, 0.01482f);
            f21.AddVertex(0.45000f, 0.17000f, 0.01482f);
            faces.Add(f21);

            Face f22 = new Face();
            f22.AddVertex(-0.43000f, 0.65000f, -0.01000f);
            f22.AddVertex(-0.37810f, 0.61801f, -0.07000f);
            f22.AddVertex(-0.37810f, 0.15198f, -0.07000f);
            f22.AddVertex(-0.43000f, 0.12000f, -0.01000f);
            faces.Add(f22);

            Face f23 = new Face();
            f23.AddVertex(-0.37810f, 0.61801f, -0.07000f);
            f23.AddVertex(0.37810f, 0.61801f, -0.07000f);
            f23.AddVertex(0.37810f, 0.15198f, -0.07000f);
            f23.AddVertex(-0.37810f, 0.15198f, -0.07000f);
            faces.Add(f23);

            Face f24 = new Face();
            f24.AddVertex(0.37810f, 0.61801f, -0.07000f);
            f24.AddVertex(0.43000f, 0.65000f, -0.01000f);
            f24.AddVertex(0.43000f, 0.12000f, -0.01000f);
            f24.AddVertex(0.37810f, 0.15198f, -0.07000f);
            faces.Add(f24);

            Face f25 = new Face();
            f25.AddVertex(0.43000f, 0.65000f, -0.01000f);
            f25.AddVertex(-0.43000f, 0.65000f, -0.01000f);
            f25.AddVertex(-0.43000f, 0.12000f, -0.01000f);
            f25.AddVertex(0.43000f, 0.12000f, -0.01000f);
            faces.Add(f25);

            Face f26 = new Face();
            f26.AddVertex(-0.43000f, 0.12000f, -0.01000f);
            f26.AddVertex(-0.37810f, 0.15198f, -0.07000f);
            f26.AddVertex(0.37810f, 0.15198f, -0.07000f);
            f26.AddVertex(0.43000f, 0.12000f, -0.01000f);
            faces.Add(f26);

            Face f27 = new Face();
            f27.AddVertex(0.43000f, 0.65000f, -0.01000f);
            f27.AddVertex(0.37810f, 0.61801f, -0.07000f);
            f27.AddVertex(-0.37810f, 0.61801f, -0.07000f);
            f27.AddVertex(-0.43000f, 0.65000f, -0.01000f);
            faces.Add(f27);

            Face f28 = new Face();
            f28.AddVertex(-0.23918f, 0.03000f, 0.09567f);
            f28.AddVertex(-0.23918f, 0.03000f, -0.09567f);
            f28.AddVertex(-0.25000f, 0.00000f, -0.10000f);
            f28.AddVertex(-0.25000f, 0.00000f, 0.10000f);
            faces.Add(f28);

            Face f29 = new Face();
            f29.AddVertex(-0.23918f, 0.03000f, -0.09567f);
            f29.AddVertex(0.23918f, 0.03000f, -0.09567f);
            f29.AddVertex(0.25000f, 0.00000f, -0.10000f);
            f29.AddVertex(-0.25000f, 0.00000f, -0.10000f);
            faces.Add(f29);

            Face f30 = new Face();
            f30.AddVertex(0.23918f, 0.03000f, -0.09567f);
            f30.AddVertex(0.23918f, 0.03000f, 0.09567f);
            f30.AddVertex(0.25000f, 0.00000f, 0.10000f);
            f30.AddVertex(0.25000f, 0.00000f, -0.10000f);
            faces.Add(f30);

            Face f31 = new Face();
            f31.AddVertex(0.23918f, 0.03000f, 0.09567f);
            f31.AddVertex(-0.23918f, 0.03000f, 0.09567f);
            f31.AddVertex(-0.25000f, 0.00000f, 0.10000f);
            f31.AddVertex(0.25000f, 0.00000f, 0.10000f);
            faces.Add(f31);

            Face f32 = new Face();
            f32.AddVertex(-0.25000f, 0.00000f, 0.10000f);
            f32.AddVertex(-0.25000f, 0.00000f, -0.10000f);
            f32.AddVertex(0.25000f, 0.00000f, -0.10000f);
            f32.AddVertex(0.25000f, 0.00000f, 0.10000f);
            faces.Add(f32);

            Face f33 = new Face();
            f33.AddVertex(0.23918f, 0.03000f, 0.09567f);
            f33.AddVertex(0.23918f, 0.03000f, -0.09567f);
            f33.AddVertex(-0.23918f, 0.03000f, -0.09567f);
            f33.AddVertex(-0.23918f, 0.03000f, 0.09567f);
            faces.Add(f33);

            Face f34 = new Face();
            f34.AddVertex(-0.05000f, 0.20000f, -0.01700f);
            f34.AddVertex(-0.05000f, 0.20000f, -0.06000f);
            f34.AddVertex(-0.05000f, 0.03000f, -0.06000f);
            f34.AddVertex(-0.05000f, 0.03000f, -0.01700f);
            faces.Add(f34);

            Face f35 = new Face();
            f35.AddVertex(-0.05000f, 0.20000f, -0.06000f);
            f35.AddVertex(0.05000f, 0.20000f, -0.06000f);
            f35.AddVertex(0.05000f, 0.03000f, -0.06000f);
            f35.AddVertex(-0.05000f, 0.03000f, -0.06000f);
            faces.Add(f35);

            Face f36 = new Face();
            f36.AddVertex(0.05000f, 0.20000f, -0.06000f);
            f36.AddVertex(0.05000f, 0.20000f, -0.01700f);
            f36.AddVertex(0.05000f, 0.03000f, -0.01700f);
            f36.AddVertex(0.05000f, 0.03000f, -0.06000f);
            faces.Add(f36);

            Face f37 = new Face();
            f37.AddVertex(0.05000f, 0.20000f, -0.01700f);
            f37.AddVertex(-0.05000f, 0.20000f, -0.01700f);
            f37.AddVertex(-0.05000f, 0.03000f, -0.01700f);
            f37.AddVertex(0.05000f, 0.03000f, -0.01700f);
            faces.Add(f37);

            Face f38 = new Face();
            f38.AddVertex(-0.05000f, 0.03000f, -0.01700f);
            f38.AddVertex(-0.05000f, 0.03000f, -0.06000f);
            f38.AddVertex(0.05000f, 0.03000f, -0.06000f);
            f38.AddVertex(0.05000f, 0.03000f, -0.01700f);
            faces.Add(f38);

            Face f39 = new Face();
            f39.AddVertex(0.05000f, 0.20000f, -0.01700f);
            f39.AddVertex(0.05000f, 0.20000f, -0.06000f);
            f39.AddVertex(-0.05000f, 0.20000f, -0.06000f);
            f39.AddVertex(-0.05000f, 0.20000f, -0.01700f);
            faces.Add(f39);

            Face f40 = new Face();
            f40.AddVertex(-0.42871f, 0.67000f, 0.01000f);
            f40.AddVertex(-0.43935f, 0.66714f, 0.01000f);
            f40.AddVertex(-0.43460f, 0.65530f, 0.01000f);
            faces.Add(f40);

            Face f41 = new Face();
            f41.AddVertex(-0.43935f, 0.66714f, 0.01000f);
            f41.AddVertex(-0.44714f, 0.65935f, 0.01000f);
            f41.AddVertex(-0.43460f, 0.65530f, 0.01000f);
            faces.Add(f41);

            Face f42 = new Face();
            f42.AddVertex(-0.44714f, 0.65935f, 0.01000f);
            f42.AddVertex(-0.45000f, 0.64871f, 0.01000f);
            f42.AddVertex(-0.43460f, 0.65530f, 0.01000f);
            faces.Add(f42);

            Face f43 = new Face();
            f43.AddVertex(0.45000f, 0.64871f, 0.01000f);
            f43.AddVertex(0.44714f, 0.65935f, 0.01000f);
            f43.AddVertex(0.43460f, 0.65530f, 0.01000f);
            faces.Add(f43);

            Face f44 = new Face();
            f44.AddVertex(0.44714f, 0.65935f, 0.01000f);
            f44.AddVertex(0.43935f, 0.66714f, 0.01000f);
            f44.AddVertex(0.43460f, 0.65530f, 0.01000f);
            faces.Add(f44);

            Face f45 = new Face();
            f45.AddVertex(0.43935f, 0.66714f, 0.01000f);
            f45.AddVertex(0.42871f, 0.67000f, 0.01000f);
            f45.AddVertex(0.43460f, 0.65530f, 0.01000f);
            faces.Add(f45);

            Face f46 = new Face();
            f46.AddVertex(-0.42871f, 0.67000f, 0.01000f);
            f46.AddVertex(-0.42871f, 0.67000f, -0.01000f);
            f46.AddVertex(-0.43935f, 0.66714f, -0.01000f);
            f46.AddVertex(-0.43935f, 0.66714f, 0.01000f);
            faces.Add(f46);

            Face f47 = new Face();
            f47.AddVertex(-0.43935f, 0.66714f, 0.01000f);
            f47.AddVertex(-0.43935f, 0.66714f, -0.01000f);
            f47.AddVertex(-0.44714f, 0.65935f, -0.01000f);
            f47.AddVertex(-0.44714f, 0.65935f, 0.01000f);
            faces.Add(f47);

            Face f48 = new Face();
            f48.AddVertex(-0.44714f, 0.65935f, 0.01000f);
            f48.AddVertex(-0.44714f, 0.65935f, -0.01000f);
            f48.AddVertex(-0.45000f, 0.64871f, -0.01000f);
            f48.AddVertex(-0.45000f, 0.64871f, 0.01000f);
            faces.Add(f48);

            Face f49 = new Face();
            f49.AddVertex(-0.42871f, 0.10000f, -0.01000f);
            f49.AddVertex(-0.42871f, 0.10000f, 0.01000f);
            f49.AddVertex(-0.43935f, 0.10285f, 0.01000f);
            f49.AddVertex(-0.43935f, 0.10285f, -0.01000f);
            faces.Add(f49);

            Face f50 = new Face();
            f50.AddVertex(-0.43935f, 0.10285f, -0.01000f);
            f50.AddVertex(-0.43935f, 0.10285f, 0.01000f);
            f50.AddVertex(-0.44714f, 0.11064f, 0.01000f);
            f50.AddVertex(-0.44714f, 0.11064f, -0.01000f);
            faces.Add(f50);

            Face f51 = new Face();
            f51.AddVertex(-0.44714f, 0.11064f, -0.01000f);
            f51.AddVertex(-0.44714f, 0.11064f, 0.01000f);
            f51.AddVertex(-0.45000f, 0.12128f, 0.01000f);
            f51.AddVertex(-0.45000f, 0.12128f, -0.01000f);
            faces.Add(f51);

            Face f52 = new Face();
            f52.AddVertex(0.42871f, 0.67000f, -0.01000f);
            f52.AddVertex(0.42871f, 0.67000f, 0.01000f);
            f52.AddVertex(0.43935f, 0.66714f, 0.01000f);
            f52.AddVertex(0.43935f, 0.66714f, -0.01000f);
            faces.Add(f52);

            Face f53 = new Face();
            f53.AddVertex(0.43935f, 0.66714f, -0.01000f);
            f53.AddVertex(0.43935f, 0.66714f, 0.01000f);
            f53.AddVertex(0.44714f, 0.65935f, 0.01000f);
            f53.AddVertex(0.44714f, 0.65935f, -0.01000f);
            faces.Add(f53);

            Face f54 = new Face();
            f54.AddVertex(0.44714f, 0.65935f, -0.01000f);
            f54.AddVertex(0.44714f, 0.65935f, 0.01000f);
            f54.AddVertex(0.45000f, 0.64871f, 0.01000f);
            f54.AddVertex(0.45000f, 0.64871f, -0.01000f);
            faces.Add(f54);

            Face f55 = new Face();
            f55.AddVertex(0.42871f, 0.10000f, 0.01000f);
            f55.AddVertex(0.42871f, 0.10000f, -0.01000f);
            f55.AddVertex(0.43935f, 0.10285f, -0.01000f);
            f55.AddVertex(0.43935f, 0.10285f, 0.01000f);
            faces.Add(f55);

            Face f56 = new Face();
            f56.AddVertex(0.43935f, 0.10285f, 0.01000f);
            f56.AddVertex(0.43935f, 0.10285f, -0.01000f);
            f56.AddVertex(0.44714f, 0.11064f, -0.01000f);
            f56.AddVertex(0.44714f, 0.11064f, 0.01000f);
            faces.Add(f56);

            Face f57 = new Face();
            f57.AddVertex(0.44714f, 0.11064f, 0.01000f);
            f57.AddVertex(0.44714f, 0.11064f, -0.01000f);
            f57.AddVertex(0.45000f, 0.12128f, -0.01000f);
            f57.AddVertex(0.45000f, 0.12128f, 0.01000f);
            faces.Add(f57);

            Face f58 = new Face();
            f58.AddVertex(-0.42871f, 0.10000f, 0.01000f);
            f58.AddVertex(-0.42871f, 0.10000f, 0.01482f);
            f58.AddVertex(-0.43935f, 0.10285f, 0.01482f);
            f58.AddVertex(-0.43935f, 0.10285f, 0.01000f);
            faces.Add(f58);

            Face f59 = new Face();
            f59.AddVertex(-0.43935f, 0.10285f, 0.01000f);
            f59.AddVertex(-0.43935f, 0.10285f, 0.01482f);
            f59.AddVertex(-0.44714f, 0.11064f, 0.01482f);
            f59.AddVertex(-0.44714f, 0.11064f, 0.01000f);
            faces.Add(f59);

            Face f60 = new Face();
            f60.AddVertex(-0.44714f, 0.11064f, 0.01000f);
            f60.AddVertex(-0.44714f, 0.11064f, 0.01482f);
            f60.AddVertex(-0.45000f, 0.12128f, 0.01482f);
            f60.AddVertex(-0.45000f, 0.12128f, 0.01000f);
            faces.Add(f60);

            Face f61 = new Face();
            f61.AddVertex(0.42871f, 0.10000f, 0.01482f);
            f61.AddVertex(0.42871f, 0.10000f, 0.01000f);
            f61.AddVertex(0.43935f, 0.10285f, 0.01000f);
            f61.AddVertex(0.43935f, 0.10285f, 0.01482f);
            faces.Add(f61);

            Face f62 = new Face();
            f62.AddVertex(0.43935f, 0.10285f, 0.01482f);
            f62.AddVertex(0.43935f, 0.10285f, 0.01000f);
            f62.AddVertex(0.44714f, 0.11064f, 0.01000f);
            f62.AddVertex(0.44714f, 0.11064f, 0.01482f);
            faces.Add(f62);

            Face f63 = new Face();
            f63.AddVertex(0.44714f, 0.11064f, 0.01482f);
            f63.AddVertex(0.44714f, 0.11064f, 0.01000f);
            f63.AddVertex(0.45000f, 0.12128f, 0.01000f);
            f63.AddVertex(0.45000f, 0.12128f, 0.01482f);
            faces.Add(f63);

            Face f64 = new Face();
            f64.AddVertex(-0.42871f, 0.10000f, 0.01000f);
            f64.AddVertex(-0.42871f, 0.10000f, -0.01000f);
            f64.AddVertex(0.42871f, 0.10000f, -0.01000f);
            f64.AddVertex(0.42871f, 0.10000f, 0.01000f);
            faces.Add(f64);

            //Imitando al metodo GL.Scale()
            //Aumentando el tamaño x30
            foreach (Face f in faces)
            {
                List<Vector3> vertices = f.GetVertices();
                for (int i = 0; i < vertices.Count; i++)
                {
                    Vector3 vertex = vertices[i];
                    vertex.X *= 20;
                    vertex.Y *= 20;
                    vertex.Z *= 20;
                    vertices[i] = vertex;
                }
            }
            //Luego este proceso sera pasado a la class Object

            return faces;
        }
    }
}
