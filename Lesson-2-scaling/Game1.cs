using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson_2_scaling
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;
        Rectangle blackRect;
        Rectangle purpCirc;
        Rectangle redRect;
        
        Rectangle topRect;
        Rectangle halfRect;
        Rectangle bottomRect;
        Rectangle topCenterRect;

        SpriteFont textFont;

        Texture2D rectangle;
        Texture2D circle;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            blackRect = new Rectangle(200, 450, 100, 25);
            redRect = new Rectangle(50, 500, 100, 25);
            purpCirc = new Rectangle(250, 50, 500, 500);
            
            topRect = new Rectangle(0, 0, window.Width, 15);
            halfRect = new Rectangle(0, 100, window.Width/2, window.Height/2);
            bottomRect = new Rectangle(0, window.Height-20, window.Width, 20);
            topCenterRect = new Rectangle(window.Width/2, 0, window.Width/2, 20);

            _graphics.ApplyChanges();


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            textFont = Content.Load<SpriteFont>("TextFont");

            // TODO: use this.Content to load your game content here
            circle = Content.Load<Texture2D>("Circle");
            rectangle = Content.Load<Texture2D>("Rectangle");
            textFont = Content.Load<SpriteFont>("TextFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            _spriteBatch.Begin();

            _spriteBatch.Draw(rectangle, blackRect, Color.Black);
            _spriteBatch.Draw(rectangle, redRect, Color.Red);
            _spriteBatch.Draw(circle, purpCirc, Color.BlueViolet);
            _spriteBatch.Draw(rectangle, topRect, Color.DeepPink);
            _spriteBatch.Draw(rectangle, halfRect, Color.Gray);
            _spriteBatch.Draw(rectangle, bottomRect, Color.MonoGameOrange);
            _spriteBatch.Draw(rectangle, topCenterRect, Color.Blue);

            _spriteBatch.DrawString(textFont, "What's Up", new Vector2(100, 100), Color.Black);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
