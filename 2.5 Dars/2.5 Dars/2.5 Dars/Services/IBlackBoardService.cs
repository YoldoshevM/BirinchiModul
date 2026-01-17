using _2._5_Dars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Dars.Services;

public interface IBlackBoardService 
{

    public Guid AddBlackBoard(BlackBoard blackboard);

    public bool DeleteBlackBoard(Guid blackBoardId);
    public bool UpdateBlackBoard(BlackBoard blackboard);

    public BlackBoard? GetBlackBoardById(Guid blackBoardId);

    public List<BlackBoard> GetAllBlackBoards();



}
