using Chilli;
namespace Application {
    public class CameraFollow: ChilliScript
    {
        private TransformComponent TransformComponent;
        private Entity Player;
        public override void OnCreate()
        {
            Player = Entity.FindByName("Player");
            TransformComponent = Entity.GetComponent<TransformComponent>();
        }
    
        public override void OnDestroy() 
        {}
    
        public override void OnUpdate(float dt) 
        {
            Vector3 translation = TransformComponent.Translation;
            translation.X = Player.GetComponent<TransformComponent>().Translation.X;
          
            TransformComponent.Translation = translation;
        }
    }
}