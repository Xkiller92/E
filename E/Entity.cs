using Taped.Core;
using OpenTK.Windowing.GraphicsLibraryFramework;
namespace E
{
    //make a chest game at the end to demonstrate 

    public class Entity : GameObject
    {
        public override void Start()
        {
            animator.LoadTexture("E.png", 1);
            //AddToActiveScene();
            base.Start();
        }

        public override void Update(double time, KeyboardState key)
        {
           
                Entity2 a = new Entity2();
            
        }
    }

    public class Entity2 : GameObject
    {
        public override void Awake()
        {
            animator.LoadTexture("E.png", 1);
            base.Awake();
        }

        public override void Update(double time, KeyboardState key)
        {
            transform.position += new OpenTK.Mathematics.Vector3(1, 0, 0) * 1000 * (float)time;
            base.Update(time, key);
        }
    }
}