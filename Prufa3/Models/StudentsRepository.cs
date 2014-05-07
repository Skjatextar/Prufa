using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApplication.Models
{
	/// <summary>
	/// This class takes care of interacting with the datastore. Currently, we are just
	/// using an in-memory list of students, but we will change this class later
	/// so it will use a database instead.
	/// </summary>
	public class StudentRepository
	{
		// Note: don't let the "static" keyword fool you, this is just here
		// so we can emulate a database! Variables should otherwise never
		// be static!
		private static List<Student> m_students = new List<Student>( );

		/// <summary>
		/// Returns a list of all students.
		/// </summary>
		/// <returns></returns>
		public List<Student> GetAllStudents( )
		{
			if ( m_students.Count == 0 )
			{
                m_students.Add(new Student  { ID = 1 , Name = "Star Wars: Episode I - The Phantom Menace"      , year = 1999 });
                m_students.Add(new Student  { ID = 2 , Name = "The Shawshank Redemption )"                     , year = 1994 });
                m_students.Add(new Student  { ID = 3 , Name = "The Godfather"                                  , year = 1972 });
                m_students.Add(new Student  { ID = 4 , Name = "The Godfather: Part II"                         , year = 1974 });
                m_students.Add(new Student  { ID = 5 , Name = "The Dark Knight"                                , year = 2008 });
                m_students.Add(new Student  { ID = 6, Name = " Pulp Fiction"                                   , year = 1994 });
                m_students.Add(new Student  { ID = 7, Name = "The Good, the Bad and the Ugly"                  , year = 1966 });
                m_students.Add(new Student  { ID = 8, Name = "Schindler's List"                                , year = 1993 });
                m_students.Add(new Student  { ID = 9, Name = "12 Angry Men"                                    , year = 1957 });
                m_students.Add(new Student  { ID = 10, Name = "The Lord of the Rings: The Return of the King " , year = 2003 });
			}

			return m_students;
		}

		/// <summary>
		/// Returns a single student with the given ID, or null if no such student can be found.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Student GetStudentById( int id )
		{
			var result = (from student in m_students
						 where student.ID == id
						 select student).SingleOrDefault( );

			return result;
		}

		/// <summary>
		/// Adds a new student to the repository. Note that no validation is performed
		/// at this moment.
		/// </summary>
		/// <param name="s"></param>
		public void AddStudent( Student s )
		{
			// "Poor man's autoincrement" :-)
			s.ID = ( from student in m_students
					 select student.ID ).Max( ) + 1;

			m_students.Add( s );
		}

		/// <summary>
		/// Updates an existing student.
		/// </summary>
		/// <param name="s"></param>
		public void UpdateStudent( Student s )
		{
			for ( int i = 0; i < m_students.Count; i++ )
			{
				if ( s.ID == m_students[i].ID )
				{
					m_students[i] = s;
					break;
				}
			}
		}
	}
}