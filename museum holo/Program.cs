using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Urho;
using Urho.Actions;
using Urho.SharpReality;
using Urho.Shapes;
using Urho.Resources;
using Urho.Gui;

namespace museum_holo
{
    internal class Program
    {
        [MTAThread]
        static void Main()
        {
            var appViewSource = new UrhoAppViewSource<HelloWorldApplication>(new ApplicationOptions("Data"));
            appViewSource.UrhoAppViewCreated += OnViewCreated;
            CoreApplication.Run(appViewSource);
        }

        static void OnViewCreated(UrhoAppView view)
        {
            view.WindowIsSet += View_WindowIsSet;
        }

        static void View_WindowIsSet(Windows.UI.Core.CoreWindow coreWindow)
        {
            // you can subscribe to CoreWindow events here
        }
    }
    

    public class HelloWorldApplication : StereoApplication
    {
       
        //Node Model

        Node AngklungNode;
        Node ArumbaNode;
        Node CelloNode;
        Node FluteNode;
        Node PianoNode;
        Node SerulingNode;
        Node TrumpetNode;
        Node ViolinNode;
        Node GuitarNode;

        //Node Anotasi

        Node AnotasiBiolaNode;
        Node AnotasiCloseBiolaNode;

        Node AnotasiAngklungNode;
        Node AnotasiCloseAngklungNode;

        Node AnotasiArumbaNode;
        Node AnotasiCloseArumbaNode;

        Node AnotasiCelloNode;
        Node AnotasiCloseCelloNode;

        Node AnotasiFluteNode;
        Node AnotasiCloseFluteNode;

        Node AnotasiGitarNode;
        Node AnotasiCloseGitarNode;

        Node AnotasiPianoNode;
        Node AnotasiClosePianoNode;

        Node AnotasiSerulingNode;
        Node AnotasiCloseSerulingNode;

        Node AnotasiTrumpetNode;
        Node AnotasiCloseTrumpetNode;
        Node JudulNode;
        //Node Bantuan

        Node i_AngklungNode;
        Node i_PianoNode;
        Node i_FluteNode;
        Node i_ArumbaNode;
        Node i_GitarNode;
        Node i_ViolinNode;
        Node i_CelloNode;
        Node i_TrumpetNode;






        Sprite Aim;
        AnimationController AngklungAni;
       
       
     

        public HelloWorldApplication(ApplicationOptions opts) : base(opts) { }

        protected override async void Start()
        {
            // Create a basic scene, see StereoApplication
            base.Start();

            // Enable input
            EnableGestureManipulation = true;
            EnableGestureTapped = true;

            // I

  



            //Aim Mark
            Sprite Aim = new Sprite(Context);
            Aim.Texture = ResourceCache.GetTexture2D(@"Data\SPRITE\pointer.png");
            Aim.SetAlignment(HorizontalAlignment.Center,VerticalAlignment.Center);
            Aim.Position = new IntVector2(0, 0);
            Aim.SetSize(25, 25);
            UI.Root.AddChild(Aim);

            // Scene has a lot of pre-configured components, such as Cameras (eyes), Lights, etc.
            DirectionalLight.Brightness = 1f;
            DirectionalLight.Node.SetDirection(new Vector3(-1, 0, 0.5f));



            // judul

            JudulNode = Scene.CreateChild();
            JudulNode.Name = "Judul";
            JudulNode.Position = new Vector3(0, -0.01f, 0.2f); //1.5m away
            JudulNode.SetScale(0.0005f); //D=30cm

            var Judul = JudulNode.CreateComponent<StaticModel>();
            Judul.Model = ResourceCache.GetModel(@"Data\judul\Plane.mdl");
            Judul.Material = Material.FromImage(@"Data\judul\TITTLE.png");

            //Angklung Model
            AngklungNode = Scene.CreateChild();
            AngklungNode.Name = "Angklung";
            AngklungNode.Position = new Vector3(0, -0.01f, 0.2f); //1.5m away
            AngklungNode.SetScale(0.0005f); //D=30cm

            var Angklung = AngklungNode.CreateComponent<StaticModel>();
            Angklung.Model = ResourceCache.GetModel(@"Data\ANGKLUNG\AKG 5.mdl");
            Angklung.Material = Material.FromImage(@"Data\ANGKLUNG\TEXTURE\angklung.png");

           
            //Piano Model

            PianoNode = Scene.CreateChild();
           PianoNode.Name = "Piano";
           PianoNode.Position = new Vector3(0, -0.03f, 0.2f); //1.5m away
           PianoNode.SetScale(0.0005f); //D=30cm

            var Piano = PianoNode.CreateComponent<StaticModel>();
            Piano.Model = ResourceCache.GetModel(@"Data\PIANO\MODEL\PIANO.mdl");
            Piano.Material = Material.FromImage(@"Data\PIANO\TEXTURE\piano.png");

            //ARUMBA MODEL

            ArumbaNode = Scene.CreateChild();
            ArumbaNode.Name = "Arumba";
            ArumbaNode.Position = new Vector3(0, -0.03f, 0.2f);
            ArumbaNode.SetScale(0.0007f);

            var Arumba = ArumbaNode.CreateComponent<StaticModel>();
            Arumba.Model = ResourceCache.GetModel(@"Data\ARUMBA\MODEL\ARUMBA.mdl");
            Arumba.Material = Material.FromImage(@"Data\ARUMBA\TEXTURE\arumba.png");

            ArumbaNode = Scene.CreateChild();
            ArumbaNode.Name = "Tongkat1";
            ArumbaNode.Position = new Vector3(0, -0.03f, 0.2f);
            ArumbaNode.SetScale(0.0007f);

            var Tongkat1 = ArumbaNode.CreateComponent<StaticModel>();
           Tongkat1.Model = ResourceCache.GetModel(@"Data\ARUMBA\MODEL\pemukularumba.mdl");
            Tongkat1.Material = Material.FromImage(@"Data\ARUMBA\TEXTURE\pemukul arumba.png");

         


            // Model Trumpet

            TrumpetNode = Scene.CreateChild();
            TrumpetNode.Name = "Trumpet";
            TrumpetNode.Position = new Vector3(0, -0.03f, 0.2f);
            TrumpetNode.SetScale(0.0007f);

            var Trumpet = ArumbaNode.CreateComponent<StaticModel>();
            Trumpet.Model = ResourceCache.GetModel(@"Data\TRUMPET\MODEL\TRUMPET.mdl");
            Trumpet.Material = Material.FromImage(@"Data\TRUMPET\TEXTURE\trumpet.png");

            // Model Flute

            FluteNode = Scene.CreateChild();
            FluteNode.Name = "Flute";
            FluteNode.Position = new Vector3(0, -0.03f, 0.2f);
            FluteNode.SetScale(0.0007f);

            var Flute = ArumbaNode.CreateComponent<StaticModel>();
            Flute.Model = ResourceCache.GetModel(@"Data\Flute\MODEL\FLUTE.mdl");
            Flute.Material = Material.FromImage(@"Data\FLUTE\TEXTURE\flute.png");

            

            //MODEL VIOLIN

            ViolinNode = Scene.CreateChild();
            ViolinNode.Name = "violin";
            ViolinNode.Position = new Vector3(0, -0.03f, 0.2f);
            ViolinNode.SetScale(0.0007f);

            var violin = ViolinNode.CreateComponent<StaticModel>();
            violin.Model = ResourceCache.GetModel(@"Data\VIOLIN\MODEL\VIOLIN.mdl");
            violin.Material = Material.FromImage(@"Data\VIOLIN\TEXTURE\violin.png");

            //MODEL CELLO

            CelloNode = Scene.CreateChild();
            CelloNode.Name = "Cello";
            CelloNode.Position = new Vector3(0, -0.03f, 0.2f);
            CelloNode.SetScale(0.0007f);

            var Cello = CelloNode.CreateComponent<StaticModel>();
            Cello.Model = ResourceCache.GetModel(@"Data\CELLO\MODEL\CELLO.mdl");
            Cello.Material = Material.FromImage(@"Data\CELLO\TEXTURE\cello.png");

            //Guitar Model

            GuitarNode = Scene.CreateChild();
            GuitarNode.Name = "Guitar";
            GuitarNode.Position = new Vector3(0, -0.03f, 0.2f);
            GuitarNode.SetScale(0.0007f);

            var Guitar = GuitarNode.CreateComponent<StaticModel>();
            Guitar.Model = ResourceCache.GetModel(@"Data\GITAR\GITAR.mdl");
            Guitar.Material = Material.FromImage(@"Data\GITAR\TEXTURE\guitar.png");

            // ANOTASI VIOLIN

            AnotasiBiolaNode = Scene.CreateChild();
            AnotasiBiolaNode.Name = "AnotasiBiola";
            AnotasiBiolaNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiBiolaNode.SetScale(0.0007f);

            var AnotasiBiola = AnotasiBiolaNode.CreateComponent<StaticModel>();
            AnotasiBiola.Model = ResourceCache.GetModel(@"Data\ANOTASI\BIOLA\MAIN BIOLA.mdl");
           
            AnotasiBiolaNode.Enabled = false;
        
            AnotasiCloseBiolaNode = Scene.CreateChild();
            AnotasiCloseBiolaNode.Name = "anotasiclose_biola_depan";
            AnotasiCloseBiolaNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiCloseBiolaNode.SetScale(0.0007f);
            var anotasiclose_biola_depan = AnotasiCloseBiolaNode.CreateComponent<StaticModel>();
            anotasiclose_biola_depan.Model = ResourceCache.GetModel(@"Data\ANOTASI\BIOLA\CLOSE\X BIOLA.mdl");
            AnotasiCloseBiolaNode.Enabled = false;

            //ANOTASI ANGKLUNG

            AnotasiAngklungNode = Scene.CreateChild();
            AnotasiAngklungNode.Name = "AnotasiAngklung";
            AnotasiAngklungNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiAngklungNode.SetScale(0.0007f);

            var AnotasiAngklung = AnotasiAngklungNode.CreateComponent<StaticModel>();
            AnotasiAngklung.Model = ResourceCache.GetModel(@"Data\ANOTASI\ANGKLUNG\INFORMASI ANGKLUNG.mdl");

            AnotasiAngklungNode.Enabled = false;

            AnotasiCloseAngklungNode = Scene.CreateChild();
            AnotasiCloseAngklungNode.Name = "anotasiclose_Angklung_depan";
            AnotasiCloseAngklungNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiCloseAngklungNode.SetScale(0.0007f);
            var anotasiclose_Angklung_depan = AnotasiCloseBiolaNode.CreateComponent<StaticModel>();
            anotasiclose_Angklung_depan.Model = ResourceCache.GetModel(@"Data\ANOTASI\ANGKLUNG\CLOSE\x angklung.mdl");

            AnotasiCloseAngklungNode.Enabled = false;

            //ANOTASI ARUMBA

            AnotasiArumbaNode = Scene.CreateChild();
            AnotasiArumbaNode.Name = "AnotasiArumba";
            AnotasiArumbaNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiArumbaNode.SetScale(0.0007f);

            var AnotasiArumba = AnotasiArumbaNode.CreateComponent<StaticModel>();
            AnotasiArumba.Model = ResourceCache.GetModel(@"Data\ANOTASI\ARUMBA\main arumba.mdl");

            AnotasiArumbaNode.Enabled = false;

            AnotasiCloseArumbaNode = Scene.CreateChild();
            AnotasiCloseArumbaNode.Name = "anotasiclose_Arumba_depan";
            AnotasiCloseArumbaNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiCloseArumbaNode.SetScale(0.0007f);
            var anotasiclose_Arumba_depan = AnotasiCloseArumbaNode.CreateComponent<StaticModel>();
            anotasiclose_Arumba_depan.Model = ResourceCache.GetModel(@"Data\ANOTASI\ARUMBA\CLOSE\x arumba.mdl");
            AnotasiCloseArumbaNode.Enabled = false;

            //ANOTASI CELLO

            AnotasiCelloNode = Scene.CreateChild();
            AnotasiCelloNode.Name = "AnotasiCello";
            AnotasiCelloNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiCelloNode.SetScale(0.0007f);

            var AnotasiCello = AnotasiCelloNode.CreateComponent<StaticModel>();
            AnotasiCello.Model = ResourceCache.GetModel(@"Data\ANOTASI\CELLO\MAIN SELO.mdl");

            AnotasiCelloNode.Enabled = false;

            AnotasiCloseCelloNode = Scene.CreateChild();
            AnotasiCloseCelloNode.Name = "anotasiclose_Cello_depan";
            AnotasiCloseCelloNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiCloseCelloNode.SetScale(0.0007f);
            var anotasiclose_Cello_depan = AnotasiCloseCelloNode.CreateComponent<StaticModel>();
            anotasiclose_Cello_depan.Model = ResourceCache.GetModel(@"Data\ANOTASI\CELLO\CLOSE\X SELO.mdl");

            AnotasiCloseCelloNode.Enabled = false;

           //ANOTASI FLUTE

           AnotasiFluteNode = Scene.CreateChild();
            AnotasiFluteNode.Name = "AnotasiFlute";
            AnotasiFluteNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiFluteNode.SetScale(0.0007f);

            var AnotasiFlute = AnotasiFluteNode.CreateComponent<StaticModel>();
            AnotasiFlute.Model = ResourceCache.GetModel(@"Data\ANOTASI\FLUTE\INFORMASI FLUTE.001.mdl");

            AnotasiCelloNode.Enabled = true;

            AnotasiCloseFluteNode = Scene.CreateChild();
            AnotasiCloseFluteNode.Name = "anotasiclose_Flute_depan";
            AnotasiCloseFluteNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiCloseFluteNode.SetScale(0.0007f);
            var anotasiclose_Flute_depan = AnotasiCloseCelloNode.CreateComponent<StaticModel>();
            anotasiclose_Flute_depan.Model = ResourceCache.GetModel(@"Data\ANOTASI\FLUTE\CLOSE\CLOSE FLUTE.mdl");
            AnotasiCloseFluteNode.Enabled = false;

            //ANOTASI GITAR

            AnotasiGitarNode = Scene.CreateChild();
            AnotasiGitarNode.Name = "AnotasiGuitar";
            AnotasiGitarNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiGitarNode.SetScale(0.0007f);

            var AnotasiGuitar = AnotasiGitarNode.CreateComponent<StaticModel>();
            AnotasiGuitar.Model = ResourceCache.GetModel(@"Data\ANOTASI\GITAR\GITAR INFORMASI.mdl");

            AnotasiGitarNode.Enabled = false;

            AnotasiCloseGitarNode = Scene.CreateChild();
            AnotasiCloseGitarNode.Name = "anotasiclose_Guitar_depan";
            AnotasiCloseGitarNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiCloseGitarNode.SetScale(0.0007f);
            var anotasiclose_Guitar_depan = AnotasiCloseGitarNode.CreateComponent<StaticModel>();
            anotasiclose_Guitar_depan.Model = ResourceCache.GetModel(@"Data\ANOTASI\GITAR\CLOSE\X GITAR.mdl");

            AnotasiCloseGitarNode.Enabled = false;

            //ANOTASI PIANO

            AnotasiPianoNode = Scene.CreateChild();
            AnotasiPianoNode.Name = "AnotasiPiano";
            AnotasiPianoNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiPianoNode.SetScale(0.0007f);

            var AnotasiPiano = AnotasiPianoNode.CreateComponent<StaticModel>();
            AnotasiPiano.Model = ResourceCache.GetModel(@"Data\ANOTASI\PIANO\MAIN PIANO.mdl");

            AnotasiPianoNode.Enabled = false;

            AnotasiClosePianoNode = Scene.CreateChild();
            AnotasiClosePianoNode.Name = "anotasiclose_Piano_depan";
            AnotasiClosePianoNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiClosePianoNode.SetScale(0.0007f);
            var anotasiclose_Piano_depan = AnotasiClosePianoNode.CreateComponent<StaticModel>();
            anotasiclose_Piano_depan.Model = ResourceCache.GetModel(@"Data\ANOTASI\PIANO\CLOSE\X PIANO.mdl");

            AnotasiClosePianoNode.Enabled = false;



            //ANOTASI TRUMPET

            AnotasiTrumpetNode = Scene.CreateChild();
            AnotasiTrumpetNode.Name = "AnotasiTrumpet";
            AnotasiTrumpetNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiTrumpetNode.SetScale(0.0007f);

            var AnotasiTrumpet = AnotasiTrumpetNode.CreateComponent<StaticModel>();
            AnotasiTrumpet.Model = ResourceCache.GetModel(@"Data\ANOTASI\TRUMPET\main terompet.mdl");

            AnotasiTrumpetNode.Enabled = true;

            AnotasiCloseTrumpetNode = Scene.CreateChild();
            AnotasiCloseTrumpetNode.Name = "anotasiclose_Trumpet_depan";
            AnotasiCloseTrumpetNode.Position = new Vector3(0, -0.03f, 0.2f);
            AnotasiCloseTrumpetNode.SetScale(0.0007f);
            var anotasiclose_Trumpet_depan = AnotasiCloseTrumpetNode.CreateComponent<StaticModel>();
            anotasiclose_Trumpet_depan.Model = ResourceCache.GetModel(@"Data\ANOTASI\TRUMPET\CLOSE\x terompet.mdl");

            AnotasiCloseTrumpetNode.Enabled = false;

            //AnotasiCloseBiolaNode = Scene.CreateChild();
            //AnotasiCloseBiolaNode.Name = "anotasiclose_biola_belakang";
            //AnotasiCloseBiolaNode.Position = new Vector3(0, -0.03f, 0.2f);
            // AnotasiCloseBiolaNode.SetScale(0.0007f);
            //var anotasiclose_biola_belakang = AnotasiCloseBiolaNode.CreateComponent<StaticModel>();
            //anotasiclose_biola_belakang.Model = ResourceCache.GetModel(@"Data\ANOTASI\BIOLA\CLOSE\BELAKANG.mdl");



            //Guitar.Material = Material.FromImage(@"Data\CELLO\TEXTURE\cello.png");
            //anotasi_violin.Material = Material.FromImage(@"Data\ANOTASI\TEXTURE\ANOTASI MR BIOLA.png");

            //Sphere is just a StaticModel component with Sphere.mdl as a Model.

            //TrumpetBody.Material = Material.FromImage(@"Data\TRUMPET\TEXTURE\trumpet.png");

            //var TrumpetTombol1 = TrumpetTombol1Node.CreateComponent<AnimatedModel>();
            //TrumpetTombol1.Model = ResourceCache.GetModel(@"Data\TRUMPET\MODEL\TOMBOL 1.mdl");

            //var TrumpetTombol2 = TrumpetTombol2Node.CreateComponent<AnimatedModel>();
            //TrumpetTombol2.Model = ResourceCache.GetModel(@"Data\TRUMPET\MODEL\TOMBOL 2.mdl");

            // TRUMPET_ANI = TrumpetTombol1Node.CreateComponent<AnimationController>();
            //TRUMPET_ANI.Play(Gerak_Tombol1, 0, true, 0);
            //TRUMPET_ANI.Play(Gerak_Tombol2, 0, true, 0);


            //TRUMPET_TOMBOL_1_ANI.Play(Gerak_Tombol1, 0, true, 0);

            //earth.Material = Material.FromImage("Textures/Earth.jpg");

            //var moonNode = CubeNode.CreateChild();
            // moonNode.SetScale(0.27f); //27% of the Earth's size
            // moonNode.Position = new Vector3(1.2f, 0, 0);

            // Same as Sphere component:
            // var moon = moonNode.CreateComponent<StaticModel>();
            // moon.Model = CoreAssets.Models.Sphere;

            //moon.Material = Material.FromImage("Textures/Moon.jpg");

            // Run a few actions to spin the Earth, the Moon and the clouds.
            // CubeNode.RunActions(new RepeatForever(new RotateBy(duration: 1f, deltaAngleX: 0, deltaAngleY: -4, deltaAngleZ: 0)));
            await TextToSpeech("WELCOME!!!");

            // More advanced samples can be found here:
            // https://github.com/xamarin/urho-samples/tree/master/HoloLens
           
        }

        // For HL optical stabilization (optional)
        public override Vector3 FocusWorldPoint => AngklungNode.WorldPosition;

        //Handle input:

        Vector3 earthPosBeforeManipulations;
        public override void OnGestureManipulationStarted() => earthPosBeforeManipulations = AngklungNode.Position;
        public override void OnGestureManipulationUpdated(Vector3 relativeHandPosition) =>
            AngklungNode.Position = relativeHandPosition + earthPosBeforeManipulations;

        public override void OnGestureTapped()
        {
            base.OnGestureTapped();
            Ray cameraRay = RightCamera.GetScreenRay(0.5f, 0.5f);
            var result = Scene.GetComponent<Octree>().RaycastSingle(cameraRay, RayQueryLevel.Triangle, 100, DrawableFlags.Geometry, 0x70000000);
            if (result != null && result.Value.Node.Name == "violin")
            //ANOTASI BIOLA
            {

                TextToSpeech("THIS is VIOLIN");
                AnotasiBiolaNode.Enabled = true;
                AnotasiCloseBiolaNode.Enabled = true;

            }
            if (result != null && result.Value.Node.Name == "anotasiclose_biola_depan")
            {
                TextToSpeech("Violin Closed");
                AnotasiBiolaNode.Enabled = false;
                AnotasiCloseBiolaNode.Enabled = false;

            }
            //ANOTASI ANGKLUNG
            if (result != null && result.Value.Node.Name == "Angklung")
            {
                TextToSpeech("THIS is ANGKLUNG");
                AnotasiAngklungNode.Enabled = true;
                AnotasiCloseAngklungNode.Enabled = true;
            }
            if (result != null && result.Value.Node.Name == "anotasiclose_Angklung_depan")
            {
                TextToSpeech("Angklung Closed");
                AnotasiAngklungNode.Enabled = false;
                AnotasiCloseAngklungNode.Enabled = false;
            }
            //ANOTASI ARUMBA
            if (result != null && result.Value.Node.Name == "Arumba")
            {
                TextToSpeech("THIS is ARUMBA");
                AnotasiArumbaNode.Enabled = true;
                AnotasiCloseArumbaNode.Enabled = true;
            }
            if (result != null && result.Value.Node.Name == "anotasiclose_Arumba_depan")
            {
                TextToSpeech("Arumba Closed");
                AnotasiArumbaNode.Enabled = false;
                AnotasiCloseArumbaNode.Enabled = false;
            }
            //ANOTASI CELLO
            if (result != null && result.Value.Node.Name == "Cello")
            {
                TextToSpeech("THIS is CELLO");
                AnotasiCelloNode.Enabled = true;
                AnotasiCloseCelloNode.Enabled = true;
            }
            if (result != null && result.Value.Node.Name == "anotasiclose_Cello_depan")
            {
                TextToSpeech("Cello Closed");
                AnotasiCelloNode.Enabled = false;
                AnotasiCloseCelloNode.Enabled = false;
            }
            //ANOTASI FLUTE
            if (result != null && result.Value.Node.Name == "Flute")
            {
                TextToSpeech("THIS is FLUTE");
                AnotasiFluteNode.Enabled = true;
                AnotasiCloseFluteNode.Enabled = true;
            }
            if (result != null && result.Value.Node.Name == "anotasiclose_Flute_depan")
            {
                TextToSpeech("FLUTE Closed");
                AnotasiFluteNode.Enabled = false;
                AnotasiCloseFluteNode.Enabled = false;
            }
            //ANOTASI GITAR
            if (result != null && result.Value.Node.Name == "Guitar")
            {
                TextToSpeech("THIS IS Guitar");
                AnotasiGitarNode.Enabled = true;
                AnotasiCloseGitarNode.Enabled = true;
            }
            if (result != null && result.Value.Node.Name == "anotasiclose_Guitar_depan")
            {
                TextToSpeech("Guitar Closed");
                AnotasiGitarNode.Enabled = false;
                AnotasiCloseGitarNode.Enabled = false;
            }
            //ANOTASI PIANO
            if (result != null && result.Value.Node.Name == "Piano")
            {
                TextToSpeech("THIS is Piano");
                AnotasiPianoNode.Enabled = true;
                AnotasiClosePianoNode.Enabled = true;
            }
            if (result != null && result.Value.Node.Name == "anotasiclose_Piano_depan")
            {
                TextToSpeech("Closed Piano");
                AnotasiPianoNode.Enabled = false;
                AnotasiClosePianoNode.Enabled = false;
            }
            //ANOTASI SERULING
            if (result != null && result.Value.Node.Name == "Seruling")
            {
                TextToSpeech("THIS is SERULING");
                AnotasiSerulingNode.Enabled = true;
                AnotasiCloseSerulingNode.Enabled = true;
            }
            if (result != null && result.Value.Node.Name == "anotasiclose_Seruling_depan")
            {
                TextToSpeech("Closed Seruling");
                AnotasiSerulingNode.Enabled = false;
                AnotasiCloseSerulingNode.Enabled = false;
            }
            //ANOTASI TRUMPET
            if (result != null && result.Value.Node.Name == "Trumpet")
            {
                TextToSpeech("THIS IS TRUMPET");
                AnotasiTrumpetNode.Enabled = true;
                AnotasiCloseTrumpetNode.Enabled = true;
            }
            if (result != null && result.Value.Node.Name == "anotasiclose_Trumpet_depan")
            {
                TextToSpeech("Closed Trumpet");
                AnotasiTrumpetNode.Enabled = false;
                AnotasiCloseTrumpetNode.Enabled = false;
            }
        }

        public override void OnGestureDoubleTapped() { }
        
    }
}