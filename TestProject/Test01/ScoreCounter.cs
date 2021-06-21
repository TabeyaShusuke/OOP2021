using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： data 読み込み　student object list 返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var stu = line.Split(',');
                var student = new Student {
                    Name = stu[0],
                    Subject = stu[1],
                    Score = int.Parse(stu[2])
                };
                students.Add(student);
            }
            return students; 
        }

        //メソッドの概要： subject別　点数集計
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var score in _score) {
                if (dict.ContainsKey(score.Subject))
                    dict[score.Subject] += score.Score;
                else
                    dict[score.Subject] = score.Score;
            }
            return dict;
        }
    }
}
