using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RGDC_Halloween_Jam_21
{
    /// <summary>
    /// Created by:
    /// Dates: 10/29/2021 - 10/31/2021
    /// For RIT Game Dev Club Halloween Jam 2021
    /// Theme: Sacrifice
    /// </summary>
    /// 

    // Game States
    enum GameState
    {
        TitleScreen,
        Game,
        GameOver,
        Win
    }

    public class Game1 : Game
    {
        //FIELDS

        private GameState currentState = GameState.TitleScreen; //current game state

        // game objects
        private Player player;
        private Creature creature;
        private List<Item> items;
        private List<Interactive> sceneComponents;

        // keyboard states
        private KeyboardState kbState;
        private KeyboardState prevKbState;

        // HUD
        private string diaBoxOut;

        // textures
        private Texture2D background;
        private Texture2D playerAsset;
        private Texture2D creatureAsset;
        private Texture2D loveInteractAsset;
        private Texture2D fruitAsset;
        private Texture2D[] buttonAssets;//0 is up, 1 is down
        private Texture2D[] doorAssets;//0 is closed, 1 is open

        // monogame stuff
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            creature = new Creature();
            player = new Player();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
