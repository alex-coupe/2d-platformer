using Chilli;

namespace Application
{
    public class PlayerMove : ChilliScript
    {
        private TransformComponent TransformComponent;
        public float Speed = 3.0f;
       
        public override void OnCreate()
        {
            TransformComponent = Entity.GetComponent<TransformComponent>();
        }

        public override void OnDestroy()
        {
            
        }

        public override void OnUpdate(float dt)
        {
            Vector3 velocity = new Vector3(0.0f, 0.0f, 0.0f);

            if (Input.IsKeyDown(KeyCode.A))
                velocity.X = -Speed;
            else if (Input.IsKeyDown(KeyCode.D))
                velocity.X = Speed;

            Vector3 translation = TransformComponent.Translation;
            translation += velocity * dt;
            TransformComponent.Translation = translation;
        }
    }
}
