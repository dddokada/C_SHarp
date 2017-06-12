using System;

// �N���X�̑O�ɂ͂��̃N���X�̐������������ق��������B

//�u///�v����n�܂�R�����g��C#�ł͓��ʂȈӖ������B
// �ڂ����́uXML Documentation�v�Ő�������B

/// <summary>
/// �R�����g�t���̃T���v���v���O�����B
/// �����ł͗�Ƃ��Ĕz��ŗ^����ꂽ�f�[�^��̕��ϒl�ƕ��U�����߂ĕ\������B
/// </summary>
class CommentSample
{
  static void Main()
  {
    // �ϐ����̌�ɕϐ��̐������������肷�邱�Ƃ��B
    // �ق�Ƃ́A�R�����g�������Ă��Ӗ��̕�����ϐ�����t����ׂ��B

    var dataSource = new[] {455,  58,   8,   7, 987,  56,   2,  64, 698,  79,       98,  79,  45, 465, 167,  97,  94, 657, 237, 587,      687, 654, 647,   4, 654, 984,   8, 489,   7,  22 }; // �f�[�^��
    double mean; // ���ϒl
    double variance;  // ���U

    // �����̋�؂育�ƂɁA�����̓��e�̊ȒP�Ȑ�������������B
    // ������A�ł���΁A�R�����g�Ȃ�ď����Ȃ��Ă�������₷���Ȍ��ȏ������������������B
    // (�u�֐��̑O�ɂ�������������Ώ\���v�ƌ����̂����z�B
    //   �v����ɁA�����̋�؂育�ƂɊ֐��ɕ�����Ă���������B
    // �R�����g���K�v�����ȏ����̋�؂肪��������A�������֐�������B)

    // �f�[�^�� dataSource �̕��ϒl�ƕ��U�����߂�
    CalcMean(dataSource, out mean, out variance);

    // ���ʂ̕\��
    Console.WriteLine("���� : {0}, ���U : {1}", mean, variance);
  }

  // �֐��̑O�ɂ͂��̊֐��̐����������B

  /// <summary>
  /// �z��ɓ������f�[�^�̕��ϒl�ƕ��U�����߂�
  /// <param name="data">�^����ꂽ�f�[�^��</param>
  /// <param name="mean">data�̕��ϒl(�o��)</param>
  /// <param name="variance">data�̕��U(�o��)</param>
  /// </summary>
  static void CalcMean(int[] data, out double mean, out double variance)
  {
    int sum = 0;     // ���v
    int sq_sum = 0;  // ���̍��v

    // �f�[�^��̍��v�Ɠ��̍��v�����߂�
    foreach(int n in data)
    {
      sum += n;
      sq_sum += n*n;
    }
    // ���ϒl�ƕ��U���v�Z
    mean = (double)sum / data.Length;
    variance = (double)sq_sum / data.Length - mean*mean;
  }
}