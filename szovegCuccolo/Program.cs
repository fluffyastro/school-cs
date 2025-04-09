namespace szovegCuccolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alapSzoveg = "ChatGPT is based on particular GPT foundation models, namely GPT-4, GPT-4o and GPT-4o mini, that were fine-tuned to target conversational usage.[17] The fine-tuning process leveraged supervised learning and reinforcement learning from human feedback (RLHF).[18][19] Both approaches employed human trainers to improve model performance. In the case of supervised learning, the trainers played both sides: the user and the AI assistant. In the reinforcement learning stage, human trainers first ranked responses that the model had created in a previous conversation.[20] These rankings were used to create reward models that were used to fine-tune the model further by using several iterations of proximal policy optimization.[18][21]ChatGPT is based on particular GPT foundation models, namely GPT-4, GPT-4o and GPT-4o mini, that were fine-tuned to target conversational usage.[17] The fine-tuning process leveraged supervised learning and reinforcement learning from human feedback (RLHF).[18][19] Both approaches employed human trainers to improve model performance. In the case of supervised learning, the trainers played both sides: the user and the AI assistant. In the reinforcement learning stage, human trainers first ranked responses that the model had created in a previous conversation.[20] These rankings were used to create reward models that were used to fine-tune the model further by using several iterations of proximal policy optimization.[18][21]ChatGPT is based on particular GPT foundation models, namely GPT-4, GPT-4o and GPT-4o mini, that were fine-tuned to target conversational usage.[17] The fine-tuning process leveraged supervised learning and reinforcement learning from human feedback (RLHF).[18][19] Both approaches employed human trainers to improve model performance. In the case of supervised learning, the trainers played both sides: the user and the AI assistant. In the reinforcement learning stage, human trainers first ranked responses that the model had created in a previous conversation.[20] These rankings were used to create reward models that were used to fine-tune the model further by using several iterations of proximal policy optimization.[18][21]ChatGPT is based on particular GPT foundation models, namely GPT-4, GPT-4o and GPT-4o mini, that were fine-tuned to target conversational usage.[17] The fine-tuning process leveraged supervised learning and reinforcement learning from human feedback (RLHF).[18][19] Both approaches employed human trainers to improve model performance. In the case of supervised learning, the trainers played both sides: the user and the AI assistant. In the reinforcement learning stage, human trainers first ranked responses that the model had created in a previous conversation.[20] These rankings were used to create reward models that were used to fine-tune the model further by using several iterations of proximal policy optimization.[18][21]";
            string modositottSzoveg = alapSzoveg;
            modositottSzoveg = modositottSzoveg.Trim();
            modositottSzoveg = modositottSzoveg.Replace("[", "");
            modositottSzoveg = modositottSzoveg.Replace("]", "");
            modositottSzoveg = modositottSzoveg.Replace(",", "");
            modositottSzoveg = modositottSzoveg.Replace(".", "");
            modositottSzoveg = modositottSzoveg.Replace("-", "");
            modositottSzoveg = modositottSzoveg.Replace("_", "");
            modositottSzoveg = modositottSzoveg.Replace("'", "");
            modositottSzoveg = modositottSzoveg.Replace("+", "");
            modositottSzoveg = modositottSzoveg.Replace("!", "");
            modositottSzoveg = modositottSzoveg.Replace("%", "");
            modositottSzoveg = modositottSzoveg.Replace("/", "");
            modositottSzoveg = modositottSzoveg.Replace("=", "");
            modositottSzoveg = modositottSzoveg.Replace("(", "");
            modositottSzoveg = modositottSzoveg.Replace(")", "");
            Console.WriteLine(modositottSzoveg);


        }
    }
}
