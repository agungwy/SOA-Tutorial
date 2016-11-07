using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prac4.Models;

namespace prac4.Controllers
{
    public class PlayerController : ApiController
    {
        

        public List<Player> print()
        {
            List<Player> players = new List<Player>();
            string lines;
            // change "players.txt" the path to the location of players.txt

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\agung\Documents\visual studio 2015\Projects\prac4\prac4\players.txt");
            while ((lines = file.ReadLine()) != null)
            {
                try
                {
                    System.Diagnostics.Debug.Write(lines);
                    string[] separators = { ", " };
                    string[] line = lines.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    Player player = new Player();
                    player.Registration_ID = line[0];
                    player.Player_name = line[1];
                    player.Team_name = line[2];
                    player.Date_of_birth = Convert.ToDateTime(line[3]);
                    players.Add(player);
                }
                catch
                {

                }
            }


            file.Close();
            return players;
        }
        public void overwrite(List<Player> players)
        {
            var tempFile = System.IO.Path.GetTempFileName();
            for (var i = 0; i < players.Count; i++)
            {
                string date = Convert.ToString(players[i].Date_of_birth);

                string newLine = players[i].Registration_ID + ", " + players[i].Player_name + ", " + players[i].Team_name + ", " + date;
                System.IO.File.AppendAllText(tempFile, Environment.NewLine + newLine);
            }
            // change "players.txt" the path to the location of players.txt
            System.IO.File.Delete(@"C:\Users\agung\Documents\visual studio 2015\Projects\prac4\prac4\players.txt");
            System.IO.File.Move(tempFile, @"C:\Users\agung\Documents\visual studio 2015\Projects\prac4\prac4\players.txt");
            
        }

        [HttpGet]
        [Route("api/player")]
        public IHttpActionResult GetAllPlayers()
        {
            List<Player> players = this.print();
            return Ok(players);
        }
        [HttpGet]
        [Route("api/player/{type}/{value}")]
        public IHttpActionResult GetPlayerInfo(string type, string value)
        {
            List<Player> players = this.print();
            if (type == "name")
            {
                List<Player> search = new List<Player>();
                for (var i = 0; i < players.Count; i++)
                {
                    if (players[i].Player_name.ToLower().Contains(value.ToLower()))
                    {
                        search.Add(players[i]);
                    }
                }
                if (search.Count == 0)
                {
                    return NotFound();
                }
                return Ok(search);
                
            }
            else
            {
                List<Player> temp = new List<Player>();
                var player = players.FirstOrDefault((p) => p.Registration_ID == value);
                if (player == null)
                {
                    return NotFound();
                }
                temp.Add(player);
                return Ok(temp);
            }

        }
        [HttpDelete]
        [Route("api/player/{type}/{value}")]
        public IHttpActionResult DeletePlayer(string type, string value)
        {
            List<Player> players = this.print();
            if (type == "name")
            {
                List<Player> temp = new List<Player>();
                bool status = false;
                for (var i = 0; i < players.Count; i++)
                {
                    if (!(players[i].Player_name.ToLower().Contains(value.ToLower())))
                    {

                        temp.Add(players[i]);
                        

                    }
                    else
                    {
                        status = true;
                    }
                }
                players = temp;
                if (status == false)
                {
                    return NotFound();
                }
                this.overwrite(players);
                return Ok("Player deleted");
                

            }
            else
            {
                var player = players.FirstOrDefault((p) => p.Registration_ID == value);
                if (player == null)
                {
                    return NotFound();
                }
                players.Remove(player);
                this.overwrite(players);
                return Ok("Player deleted");

            }
            
           
        }
        [HttpPost]
        [Route("api/player")]
        public IHttpActionResult PlayerRegistration(Player player)
        {
            List<Player> players = this.print();
            string text = ("Player Registered");
            for (var i = 0; i < players.Count; i++)
            {
                if (players[i].Registration_ID == player.Registration_ID)
                {
                    players[i].Player_name = player.Player_name;
                    players[i].Team_name = player.Team_name;
                    players[i].Date_of_birth = player.Date_of_birth;
                    text = "Player Updated";
                }

            }

            if (text == "Player Updated")
            {
                overwrite(players);
                return Ok(text);
            }
            else
            {
                players.Add(player);
                string date = Convert.ToString(player.Date_of_birth);

                string newLine = player.Registration_ID + ", " + player.Player_name + ", " + player.Team_name + ", " + date;
                // change "players.txt" the path to the location of players.txt
                System.IO.File.AppendAllText(@"C:\Users\agung\Documents\visual studio 2015\Projects\prac4\prac4\players.txt", Environment.NewLine + newLine);

                return Ok(text);
            }

           
        }
        
    }
}
