/*
* MATLAB Compiler: 6.2 (R2016a)
* Date: Fri Nov 25 11:20:35 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:HeadlightTracking,HeadLight,0.0,private"
* "-T" "link:lib" "-d"
* "C:\Users\Lenovo\Desktop\课业\软件著作\code\DaytimeTracking\HeadlightTracking\for_testin
* g" "-v"
* "class{HeadLight:C:\Users\Lenovo\Desktop\课业\软件著作\code\DaytimeTracking\HeadlightTra
* cking.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace HeadlightTracking
{

  /// <summary>
  /// The HeadLight class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Lenovo\Desktop\课业\软件著作\code\DaytimeTracking\HeadlightTracking.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class HeadLight : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static HeadLight()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "HeadlightTracking.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the HeadLight class.
    /// </summary>
    public HeadLight()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~HeadLight()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the HeadlightTracking
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// imshow(videoFrame);
    /// axis off
    /// videoFrame = insertObjectAnnotation(videoFrame, 'rectangle',bboxes,0);
    /// videoFrame=insertText(videoFrame,[50,50],nextId-1,'FontSize',50,'BoxColor','blue')
    /// ; 
    /// step(videoPlayer,videoFrame);
    /// imshow(videoFrame);
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray HeadlightTracking()
    {
      return mcr.EvaluateFunction("HeadlightTracking", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the HeadlightTracking
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// imshow(videoFrame);
    /// axis off
    /// videoFrame = insertObjectAnnotation(videoFrame, 'rectangle',bboxes,0);
    /// videoFrame=insertText(videoFrame,[50,50],nextId-1,'FontSize',50,'BoxColor','blue')
    /// ; 
    /// step(videoPlayer,videoFrame);
    /// imshow(videoFrame);
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray HeadlightTracking(MWArray fileName)
    {
      return mcr.EvaluateFunction("HeadlightTracking", fileName);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the HeadlightTracking
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// imshow(videoFrame);
    /// axis off
    /// videoFrame = insertObjectAnnotation(videoFrame, 'rectangle',bboxes,0);
    /// videoFrame=insertText(videoFrame,[50,50],nextId-1,'FontSize',50,'BoxColor','blue')
    /// ; 
    /// step(videoPlayer,videoFrame);
    /// imshow(videoFrame);
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="position">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray HeadlightTracking(MWArray fileName, MWArray position)
    {
      return mcr.EvaluateFunction("HeadlightTracking", fileName, position);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the HeadlightTracking MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// imshow(videoFrame);
    /// axis off
    /// videoFrame = insertObjectAnnotation(videoFrame, 'rectangle',bboxes,0);
    /// videoFrame=insertText(videoFrame,[50,50],nextId-1,'FontSize',50,'BoxColor','blue')
    /// ; 
    /// step(videoPlayer,videoFrame);
    /// imshow(videoFrame);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] HeadlightTracking(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "HeadlightTracking", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the HeadlightTracking MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// imshow(videoFrame);
    /// axis off
    /// videoFrame = insertObjectAnnotation(videoFrame, 'rectangle',bboxes,0);
    /// videoFrame=insertText(videoFrame,[50,50],nextId-1,'FontSize',50,'BoxColor','blue')
    /// ; 
    /// step(videoPlayer,videoFrame);
    /// imshow(videoFrame);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] HeadlightTracking(int numArgsOut, MWArray fileName)
    {
      return mcr.EvaluateFunction(numArgsOut, "HeadlightTracking", fileName);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the HeadlightTracking MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// imshow(videoFrame);
    /// axis off
    /// videoFrame = insertObjectAnnotation(videoFrame, 'rectangle',bboxes,0);
    /// videoFrame=insertText(videoFrame,[50,50],nextId-1,'FontSize',50,'BoxColor','blue')
    /// ; 
    /// step(videoPlayer,videoFrame);
    /// imshow(videoFrame);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="position">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] HeadlightTracking(int numArgsOut, MWArray fileName, MWArray position)
    {
      return mcr.EvaluateFunction(numArgsOut, "HeadlightTracking", fileName, position);
    }


    /// <summary>
    /// Provides an interface for the HeadlightTracking function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// imshow(videoFrame);
    /// axis off
    /// videoFrame = insertObjectAnnotation(videoFrame, 'rectangle',bboxes,0);
    /// videoFrame=insertText(videoFrame,[50,50],nextId-1,'FontSize',50,'BoxColor','blue')
    /// ; 
    /// step(videoPlayer,videoFrame);
    /// imshow(videoFrame);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void HeadlightTracking(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("HeadlightTracking", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
