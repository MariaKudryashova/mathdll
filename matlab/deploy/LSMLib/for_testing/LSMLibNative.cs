/*
* MATLAB Compiler: 8.4 (R2022a)
* Date: Fri Apr 15 15:46:13 2022
* Arguments:
* "-B""macro_default""-W""dotnet:LSMLib,LSMLib,4.0,private,version=1.0""-T""link:lib""-d""
* C:\Users\Maru\spb\Dev\_habr\math_tests\matlab\deploy\LSMLib\for_testing""-v""class{LSMLi
* b:C:\Users\Maru\spb\Dev\_habr\math_tests\matlab\show_lsm.m,C:\Users\Maru\spb\Dev\_habr\m
* ath_tests\matlab\solve_lsm.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace LSMLibNative
{

  /// <summary>
  /// The LSMLib class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Maru\spb\Dev\_habr\math_tests\matlab\show_lsm.m
  /// <newpara></newpara>
  /// C:\Users\Maru\spb\Dev\_habr\math_tests\matlab\solve_lsm.m
  /// </summary>
  /// <remarks>
  /// @Version 1.0
  /// </remarks>
  public class LSMLib : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static LSMLib()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

		  int lastDelimiter = ctfFilePath.LastIndexOf(@"/");

	      if (lastDelimiter == -1)
		  {
		    lastDelimiter = ctfFilePath.LastIndexOf(@"\");
		  }

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "LSMLib.ctf";

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
    /// Constructs a new instance of the LSMLib class.
    /// </summary>
    public LSMLib()
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
    ~LSMLib()
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
    /// Provides a single output, 0-input Objectinterface to the show_lsm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object show_lsm()
    {
      return mcr.EvaluateFunction("show_lsm", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the show_lsm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="n">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object show_lsm(Object n)
    {
      return mcr.EvaluateFunction("show_lsm", n);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the show_lsm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="n">Input argument #1</param>
    /// <param name="xmod">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object show_lsm(Object n, Object xmod)
    {
      return mcr.EvaluateFunction("show_lsm", n, xmod);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the show_lsm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="n">Input argument #1</param>
    /// <param name="xmod">Input argument #2</param>
    /// <param name="koeffs">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object show_lsm(Object n, Object xmod, Object koeffs)
    {
      return mcr.EvaluateFunction("show_lsm", n, xmod, koeffs);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the show_lsm MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] show_lsm(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "show_lsm", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the show_lsm MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="n">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] show_lsm(int numArgsOut, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "show_lsm", n);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the show_lsm MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="n">Input argument #1</param>
    /// <param name="xmod">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] show_lsm(int numArgsOut, Object n, Object xmod)
    {
      return mcr.EvaluateFunction(numArgsOut, "show_lsm", n, xmod);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the show_lsm MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="n">Input argument #1</param>
    /// <param name="xmod">Input argument #2</param>
    /// <param name="koeffs">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] show_lsm(int numArgsOut, Object n, Object xmod, Object koeffs)
    {
      return mcr.EvaluateFunction(numArgsOut, "show_lsm", n, xmod, koeffs);
    }


    /// <summary>
    /// Provides an interface for the show_lsm function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("show_lsm", 3, 1, 0)]
    protected void show_lsm(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("show_lsm", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the solve_lsm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object solve_lsm()
    {
      return mcr.EvaluateFunction("solve_lsm", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the solve_lsm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="n">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object solve_lsm(Object n)
    {
      return mcr.EvaluateFunction("solve_lsm", n);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the solve_lsm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="n">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object solve_lsm(Object n, Object x)
    {
      return mcr.EvaluateFunction("solve_lsm", n, x);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the solve_lsm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="n">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="y">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object solve_lsm(Object n, Object x, Object y)
    {
      return mcr.EvaluateFunction("solve_lsm", n, x, y);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the solve_lsm MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="n">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="y">Input argument #3</param>
    /// <param name="wts">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object solve_lsm(Object n, Object x, Object y, Object wts)
    {
      return mcr.EvaluateFunction("solve_lsm", n, x, y, wts);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the solve_lsm MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] solve_lsm(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "solve_lsm", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the solve_lsm MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="n">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] solve_lsm(int numArgsOut, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "solve_lsm", n);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the solve_lsm MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="n">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] solve_lsm(int numArgsOut, Object n, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "solve_lsm", n, x);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the solve_lsm MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="n">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="y">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] solve_lsm(int numArgsOut, Object n, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "solve_lsm", n, x, y);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the solve_lsm MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="n">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="y">Input argument #3</param>
    /// <param name="wts">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] solve_lsm(int numArgsOut, Object n, Object x, Object y, Object wts)
    {
      return mcr.EvaluateFunction(numArgsOut, "solve_lsm", n, x, y, wts);
    }


    /// <summary>
    /// Provides an interface for the solve_lsm function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("solve_lsm", 4, 1, 0)]
    protected void solve_lsm(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("solve_lsm", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
