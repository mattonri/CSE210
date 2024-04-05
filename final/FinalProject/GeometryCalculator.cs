public class GeometryCalculator
{
    string _name;
    public GeometryCalculator()
    {

    }
    public (Point, Point) CalculateThirdPoints(decimal mrtTolerance, Point mrtPoint1, Point mrtPoint2, decimal mrtDistance1, decimal mrtDistance2)
    {

    // 1
    Segment mrtSegment1_T = new Segment(p_starting: mrtPoint1,p_length:mrtDistance1);
    decimal d1 = mrtSegment1_T.ReturnLength();
    Segment mrtSegment2_T = new Segment(p_starting: mrtPoint2,p_length:mrtDistance2);
    decimal d2 = mrtSegment2_T.ReturnLength();

    Segment mrtSegment1_2 = new Segment(p_starting: mrtPoint1, p_ending: mrtPoint2);
    // 2
    Triangle mrtTriangle1_2_T = new Triangle();
    decimal p1Angle = mrtTriangle1_2_T.CoSinRule(d2, d1, mrtSegment1_2.ReturnLength());
    Angle mrtAnglep1_2T = new Angle(p1Angle, mrtPoint1, mrtSegment1_T, mrtSegment1_2);
    // 3

    decimal d1_3Length = mrtTriangle1_2_T.FindAdjacent(mrtSegment1_T.ReturnLength(), mrtAnglep1_2T.ReturnRadians());
    Segment mrtSegment1_3 = new Segment(mrtPoint1, d1_3Length);
    decimal d3_ratio = mrtSegment1_3.ReturnLength()/mrtSegment1_2.ReturnLength();

    Point mrtPoint3 = mrtSegment1_2.PartialTransitionAlong(d3_ratio);
    Point mrtPoint4 = new Point((decimal)mrtPoint3.GetXY().Item1, (decimal)mrtPoint1.GetXY().Item2);
    Segment mrtSegment1_4 = new Segment(mrtPoint1, mrtPoint4);
    Segment mrtSegment3_4 = new Segment(mrtPoint3, mrtPoint4);
    Triangle mrtTriangle1_4_3 = new Triangle(mrtAnglep1_2T, p_segmentA:mrtSegment3_4.ReturnLength(),p_segmentB:mrtSegment1_3.ReturnLength(),p_segmentC:mrtSegment1_3.ReturnLength(), p_tolerance:mrtTolerance);

    // 4
    decimal p1AbsoluteAngle = mrtTriangle1_4_3.CoSinRule(mrtSegment3_4.ReturnLength(), mrtSegment1_4.ReturnLength(), mrtSegment1_3.ReturnLength()) + mrtAnglep1_2T.ReturnRadians();
    
    Angle mrtAngle1_43 = new Angle(p1AbsoluteAngle, mrtPoint1);
    // 5
    decimal delta1_Tx = mrtTriangle1_4_3.FindAdjacent(p_angle: mrtAngle1_43.ReturnRadians(), p_hypotenuse: d1);
    decimal delta1_Ty = mrtTriangle1_4_3.FindOpposite(p_angle: mrtAngle1_43.ReturnRadians(), p_hypotenuse: d1);
    // 6
    Point mrtPointTarget = mrtPoint1.Transition(delta1_Tx, delta1_Ty);


    // 4.5
    decimal p1AbsoluteAngleALT = -mrtTriangle1_4_3.CoSinRule(mrtSegment3_4.ReturnLength(), mrtSegment1_4.ReturnLength(), mrtSegment1_3.ReturnLength()) + mrtAnglep1_2T.ReturnRadians();
    // 5.5
    decimal delta1_TxALT = mrtTriangle1_4_3.FindAdjacent(p_angle: p1AbsoluteAngleALT, p_hypotenuse: d1);
    decimal delta1_TyALT = mrtTriangle1_4_3.FindOpposite(p_angle: p1AbsoluteAngleALT, p_hypotenuse: d1);
    // 6.5
    Point mrtPointTargetALT = mrtPoint1.Transition(delta1_TxALT, -delta1_TyALT);
    return (mrtPointTarget, mrtPointTargetALT);
    }
}