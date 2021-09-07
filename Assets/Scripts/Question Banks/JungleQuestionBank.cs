using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class JungleQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();
    public static Question jungle001 = new Question();
    public static Question jungle002 = new Question();
    public static Question jungle003 = new Question();
    public static Question jungle004 = new Question();
    public static Question jungle005 = new Question();
    public static Question jungle006 = new Question();
    public static Question jungle007 = new Question();
    public static Question jungle008 = new Question();
    public static Question jungle009 = new Question();
    public static Question jungle010 = new Question();
    public static Question jungle011 = new Question();
    public static Question jungle012 = new Question();

    void Start()
    {
        jungle001 = new Question()
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

        jungle002 = new Question()
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

        jungle003 = new Question()
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

        jungle004 = new Question()
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

        jungle005 = new Question()
        {
            number = 5,
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

        jungle006 = new Question()
        {
            number = 6,
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

        jungle007 = new Question()
        {
            number = 7,
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

        jungle008 = new Question()
        {
            number = 8,
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

        jungle009 = new Question()
        {
            number = 9,
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

        jungle010 = new Question()
        {
            number = 10,
            questionName = "flower",
            sprite = Resources.Load<Sprite>("Questions/Home/Pre_A1_Starters/Flower"),
            answerOptions = new List<string>()
        {
            "flower",
            "panda",
            "swan",
            "bird"
        },
            tags = new List<string>()
        {
            "home"
        },
            size = 1,
            answerSound = "Flower",
            level = 1
        };

        jungle011 = new Question()
        {
            number = 11,
            questionName = "tail",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pre_A1_Starters/Tail"),
            answerOptions = new List<string>()
        {
            "tail",
            "panda",
            "swan",
            "bird"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tail",
            level = 1
        };

        jungle012 = new Question()
        {
            number = 12,
            questionName = "tree",
            sprite = Resources.Load<Sprite>("Questions/Home/Pre_A1_Starters/Tree"),
            answerOptions = new List<string>()
        {
            "tree",
            "panda",
            "swan",
            "bird"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tree",
            level = 1
        };


        LoadJungleQuestionList();
    }

    public static void LoadJungleQuestionList()
    {
        questions.Add(jungle001);

        questions.Add(jungle002);

        questions.Add(jungle003);

        questions.Add(jungle004);

        questions.Add(jungle005);

        questions.Add(jungle006);

        questions.Add(jungle006);

        questions.Add(jungle007);

        questions.Add(jungle008);

        questions.Add(jungle009);

        questions.Add(jungle010);

        questions.Add(jungle011);

        questions.Add(jungle012);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        // Debug.Log(questions.Count);
    }
}
