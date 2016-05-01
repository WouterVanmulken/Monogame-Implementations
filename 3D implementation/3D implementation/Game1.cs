using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _3D_implementation
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D texture;
        private SpriteFont sf;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            texture = Content.Load<Texture2D>("pixel");
            sf = Content.Load<SpriteFont>("sf");
//            t = new Texture2D(GraphicsDevice, 100, 100);
        }
        
        protected override void UnloadContent()
        {
        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        private Vector3 cube = new Vector3(100, 100, 1);
        
        private double rotation = 0;
       
        protected override void Draw(GameTime gameTime)
        {
            
            spriteBatch.Begin();
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);


//            rotation+=0.01;
//            rotation = (rotation%360);
//            spriteBatch.Draw(texture,destinationRectangle:new Rectangle(100,100,100,5),rotation:(float)rotation,color:Color.Aqua);
//            cube.Z = cube.Z-(float)0.01;
            spriteBatch.DrawString(sf, "X : " + cube.X + "; Y : " + cube.Y + "; Z : " + cube.Z, new Vector2(graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight / 3), color: Color.White);

            double x = cube.X/cube.Z;
            double y = cube.Y/cube.Z;
            spriteBatch.DrawString(sf,"X : " + x + "; Y : " + y,new Vector2(graphics.PreferredBackBufferWidth/2,graphics.PreferredBackBufferHeight/2),color:Color.White );
            spriteBatch.Draw(texture, destinationRectangle: new Rectangle((int)x, (int)y, 100, 5), rotation: (float)rotation, color: Color.Aqua);










            spriteBatch.End();
        }
    }
}
