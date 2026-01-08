using _2._2_Dars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2_Dars.Services;

public class SchoolService
{

    public List<School> Schools = new List<School>();
    

    public Guid AddSchool(School school)
    {

        school.SchoolId = Guid.NewGuid();
        Schools.Add(school);
        return school.SchoolId;

    }

    
    public List<School> GetSchools()
    {

        return Schools;

    }

    public bool DeleteSchool(Guid schoolId )
    {

        foreach( var school in Schools )
        {

            if ( school.SchoolId == schoolId)
            {
                Schools.Remove(school);
                return true;
            }

            return false;

        }


    }






}
