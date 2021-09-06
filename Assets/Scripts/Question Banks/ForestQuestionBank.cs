using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ForestQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();
    public static Question forest001 = new Question();
    public static Question forest002 = new Question();
    public static Question forest003 = new Question();
    public static Question forest004 = new Question();
    public static Question forest005 = new Question();
    public static Question forest006 = new Question();
    public static Question forest007 = new Question();
    public static Question forest008 = new Question();
    public static Question forest009 = new Question();

    void Start()
    {
        forest001 = new Question()
        {
            number = 1,
            questionName = "animal",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Animal"),
            answerOptions = new List<string>()
        {
            "animal",
            "panda",
            "swan",
            "dolphin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Animal",
            level = 1
        };

        forest002 = new Question()
        {
            number = 2,
            questionName = "bear",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Bear"),
            answerOptions = new List<string>()
        {
            "bear",
            "horse",
            "mouse",
            "ant"
        },
            answerBlocks = new List<char>()
        {
            'B',
            'E',
            'A',
            'R'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bear",
            level = 1
        };

        forest003 = new Question()
        {
            number = 3,
            questionName = "bee",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Bee"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "bee",
            "dolphin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bee",
            level = 1
        };

        forest004 = new Question()
        {
            number = 4,
            questionName = "bird",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Bird"),
            answerOptions = new List<string>()
        {
            "shark",
            "panda",
            "swan",
            "bird"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bird",
            level = 1
        };

        forest005 = new Question()
        {
            number = 11,
            questionName = "duck",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Duck"),
            answerOptions = new List<string>()
        {
            "duck",
            "dog",
            "cat",
            "horse"
        },
            answerBlocks = new List<char>()
        {
            'D',
            'U',
            'C',
            'K'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Duck",
            level = 1
        };

        forest006 = new Question()
        {
            number = 14,
            questionName = "frog",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Frog"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "frog"
        },
            answerBlocks = new List<char>()
        {
            'F',
            'R',
            'O',
            'G'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Frog",
            level = 1
        };

        forest007 = new Question()
        {
            number = 20,
            questionName = "lizard",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Lizard"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "lizard"
        },
            answerBlocks = new List<char>()
        {
            'L',
            'I',
            'Z',
            'A',
            'R',
            'D'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Lizard",
            level = 1
        };

        forest008 = new Question()
        {
            number = 22,
            questionName = "mouse",
            sprite = Resources.Load<Sprite>("Questions/Animals/Mouse"),
            answerBlocks = new List<char>()
        {
            'M',
            'O',
            'U',
            'S',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Mouse"
        };

        forest009 = new Question()
        {
            number = 26,
            questionName = "snake",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Snake"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "snake",
            "penguin"
        },
            answerBlocks = new List<char>()
        {
            'S',
            'N',
            'A',
            'K',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Snake",
            level = 1
        };

        LoadForestQuestionList();
    }

    public static void LoadForestQuestionList()
    {
        questions.Add(forest001);

        questions.Add(forest002);

        questions.Add(forest003);

        questions.Add(forest004);

        questions.Add(forest005);

        questions.Add(forest006);

        questions.Add(forest006);

        questions.Add(forest007);

        questions.Add(forest008);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        // Debug.Log(questions.Count);
    }
}
