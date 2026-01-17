using _2._5_Dars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Dars.Services;

public class BlackBoardService : IBlackBoardService
{

    List<BlackBoard> BlackBoards;

    public BlackBoardService()
    {
        BlackBoards = new List<BlackBoard>();
    }


    public Guid AddBlackBoard(BlackBoard blackboard)
    {
        blackboard.BlackBoardId = Guid.NewGuid();
        BlackBoards.Add(blackboard);
        return blackboard.BlackBoardId;
    }

    public bool DeleteBlackBoard(Guid blackBoardId)
    {
        foreach ( var blackboard in BlackBoards)
        {
            if ( blackboard.BlackBoardId == blackBoardId)
            {
                BlackBoards.Remove(blackboard);
                return true;
            }

        }
        return false;
    }

    public List<BlackBoard> GetAllBlackBoards()
    {
        return BlackBoards;
    }

    public BlackBoard? GetBlackBoardById(Guid blackBoardId)
    {
        foreach ( var blackboard in BlackBoards )
        {
            if ( blackboard.BlackBoardId == blackBoardId)
            {
                return blackboard;
            }
        }
        return null;
    }

    public bool UpdateBlackBoard(BlackBoard Updatingblackboard)
    {

        foreach ( var blackboard in BlackBoards )
        {
            if (blackboard.BlackBoardId == Updatingblackboard.BlackBoardId)
            {
                blackboard.Color = Updatingblackboard.Color;
                blackboard.Height = Updatingblackboard.Height;
                blackboard.Weight = Updatingblackboard.Weight;
                blackboard.Material = Updatingblackboard.Material;
                blackboard.IsClean = Updatingblackboard.IsClean;
                return true;
            }
        }
        return false;
    }
}
