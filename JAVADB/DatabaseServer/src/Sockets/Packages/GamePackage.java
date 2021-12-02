package Sockets.Packages;

import Sockets.Models.Game;

import java.io.Serializable;
import java.util.ArrayList;

public class GamePackage implements Serializable
{
  private static final long serialVersionUID = -1969032664524354115L;

  private Game game;
  private String type;
  private ArrayList<Game> games;

  public GamePackage(Game game, String type)
  {
    this.game = game;
    this.type = type;
    this.games = null;
  }

  public GamePackage(String type)
  {
    this.game = null;
    this.type = type;
    this.games = null;
  }

  public GamePackage(String type, ArrayList<Game> games)
  {
    this.game = null;
    this.type = type;
    this.games = games;
  }

  public ArrayList<Game> getGames()
  {
    return games;
  }

  public Game getGame()
  {
    return game;
  }

  public String getType()
  {
    return type;
  }
}